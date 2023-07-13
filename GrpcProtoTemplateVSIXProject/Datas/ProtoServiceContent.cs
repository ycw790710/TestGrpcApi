using System;
using System.Collections.Generic;
using System.Text;

namespace GrpcProtoTemplateVSIXProject.Datas
{
    public class ProtoServiceContent
    {
        public string Comments { get; set; }

        public string Name { get; set; }

        private readonly List<ProtoMethodContent> _protoMethodContents;
        public IReadOnlyList<ProtoMethodContent> ProtoMethodContents => _protoMethodContents;

        public ProtoServiceContent()
        {
            _protoMethodContents = new List<ProtoMethodContent>();
        }

        public ProtoMethodContent AddMethod()
        {
            var method = new ProtoMethodContent();
            _protoMethodContents.Add(method);
            return method;
        }

        public void RemoveMethod(ProtoMethodContent protoMethodContent)
        {
            _protoMethodContents.Remove(protoMethodContent);
        }

        public bool IsCommentsValid(out string message)
        {
            var isValid = !string.IsNullOrEmpty(Comments);
            message = "";
            if (!isValid)
                message = "service comments不可為空";
            return isValid;
        }

        public bool IsNameValid(out string message)
        {
            var isValid = !string.IsNullOrEmpty(Name);
            message = "";
            if (!isValid)
                message = "service name不可為空";
            return isValid;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"// {Comments}");
            sb.AppendLine($"service {Name} {{");
            sb.AppendLine(string.Join(Environment.NewLine, _protoMethodContents));
            sb.AppendLine("}");
            foreach (var protoMethodContent in _protoMethodContents)
            {
                sb.AppendLine(protoMethodContent.ProtoRequestContent.ToString());
                sb.AppendLine(protoMethodContent.ProtoReplyContent.ToString());
            }
            return sb.ToString();
        }
    }
}
