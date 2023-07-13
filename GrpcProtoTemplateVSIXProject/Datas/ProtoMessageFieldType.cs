using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GrpcProtoTemplateVSIXProject.Datas
{
    public class ProtoMessageFieldType
    {
        public static ProtoMessageFieldType Float = new ProtoMessageFieldType("float");
        public static ProtoMessageFieldType Double = new ProtoMessageFieldType("double");
        public static ProtoMessageFieldType int32 = new ProtoMessageFieldType("int32");
        public static ProtoMessageFieldType uint32 = new ProtoMessageFieldType("uint32");
        public static ProtoMessageFieldType sint32 = new ProtoMessageFieldType("sint32");
        public static ProtoMessageFieldType fixed32 = new ProtoMessageFieldType("fixed32");
        public static ProtoMessageFieldType sfixed32 = new ProtoMessageFieldType("sfixed32");
        public static ProtoMessageFieldType int64 = new ProtoMessageFieldType("int64");
        public static ProtoMessageFieldType uint64 = new ProtoMessageFieldType("uint64");
        public static ProtoMessageFieldType sint64 = new ProtoMessageFieldType("sint64");
        public static ProtoMessageFieldType fixed64 = new ProtoMessageFieldType("fixed64");
        public static ProtoMessageFieldType sfixed64 = new ProtoMessageFieldType("sfixed64");
        public static ProtoMessageFieldType Bool = new ProtoMessageFieldType("bool");
        public static ProtoMessageFieldType String = new ProtoMessageFieldType("string");
        public static ProtoMessageFieldType bytes = new ProtoMessageFieldType("bytes");

        public static ProtoMessageFieldType message = new ProtoMessageFieldType("message");
        public static ProtoMessageFieldType Timestamp = new ProtoMessageFieldType("Timestamp");


        public string SyntaxName { get; private set; }
        public ProtoMessageFieldType(string syntaxName)
        {
            SyntaxName = syntaxName;
        }

        public static IEnumerable<ProtoMessageFieldType> GetAll() =>
            typeof(ProtoMessageFieldType).GetFields(BindingFlags.Public |
                                BindingFlags.Static |
                                BindingFlags.DeclaredOnly)
                        .Select(f => f.GetValue(null))
                        .Cast<ProtoMessageFieldType>();

        public static ProtoMessageFieldType FromSyntaxName(string syntaxName)
        {
            return GetAll().FirstOrDefault(item => item.SyntaxName == syntaxName);
        }

        public override string ToString()
        {
            return SyntaxName;
        }
    }
}
