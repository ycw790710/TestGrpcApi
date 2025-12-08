using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using TestGrpcApi.Services;


namespace TestGrpcApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            // Additional configuration is required to successfully run gRPC on macOS.
            // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddGrpc();
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
           .AddJwtBearer(options =>
           {
               options.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuer = true,
                   ValidateAudience = true,
                   ValidateLifetime = true,
                   ValidateIssuerSigningKey = true,
                   ValidIssuer = "TestGrpc",
                   ValidAudience = "TestGrpc",
                   IssuerSigningKeyResolver = (string unvalidToken, SecurityToken securityToken, string kid, TokenValidationParameters validationParameters) =>
                   {
                       return new[] { new SymmetricSecurityKey(GetSecretKey()) };
                   },
                   ClockSkew = TimeSpan.Zero
               };
           });
            builder.Services.AddAuthorization();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TestGrpcApi Api", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                });

                c.AddSecurityRequirement(document =>
                    new OpenApiSecurityRequirement
                    {
            {
                new OpenApiSecuritySchemeReference("Bearer", document),
                new List<string>()
            }
                    }
                );
            });

            // Test
            Write_Test_Token();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

            // here are development settings
            app.MapGrpcService<GreeterService>().RequireHost($"*:{GetGrpcPort(builder.Configuration)}");
            app.MapGrpcService<Test2Service>().RequireHost($"*:{GetGrpcPort(builder.Configuration)}");
            app.MapGrpcService<Test1Service>().RequireHost($"*:{GetGrpcPort(builder.Configuration)}");
            app.MapGrpcService<Test3Service>().RequireHost($"*:{GetGrpcPort(builder.Configuration)}");

            app.MapControllers();

            app.Run();
        }

        static byte[] GetSecretKey()
        {
            var bytes = Encoding.UTF8.GetBytes("askjdhf98asdf9h25khns;lzdfh98sddfbu;12kjaiodhjgo;aihew4t-89q34nop;asdok;fg");
            Array.Resize(ref bytes, 64);
            return bytes;
        }

        static int GetGrpcPort(IConfiguration configuration)
        {
            var port = configuration.GetValue<int>("Ports:Grpcs");
            return port;
        }

        static void Write_Test_Token()
        {
            var key = GetSecretKey();

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("sub", "testuser") }),
                Expires = DateTime.UtcNow.AddHours(1),
                Issuer = "TestGrpc",
                Audience = "TestGrpc",
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256
                )
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwt = tokenHandler.WriteToken(token);

            Console.WriteLine("JWT Token:");
            Console.WriteLine(jwt);
        }
    }
}