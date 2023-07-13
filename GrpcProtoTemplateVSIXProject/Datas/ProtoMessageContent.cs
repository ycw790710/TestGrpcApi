using System;
using System.Collections.Generic;
using System.Text;

namespace GrpcProtoTemplateVSIXProject.Datas
{
    public class ProtoMessageContent
    {
        public string Comments { get; set; }

        public string Name { get; set; }

        private readonly List<ProtoMessageFieldContent> _protoMessageFieldContents;
        public IReadOnlyList<ProtoMessageFieldContent> ProtoMessageFieldContents => _protoMessageFieldContents;

        public ProtoMessageContent()
        {
            _protoMessageFieldContents = new List<ProtoMessageFieldContent>();
        }

        public ProtoMessageFieldContent AddField()
        {
            var field = new ProtoMessageFieldContent();
            _protoMessageFieldContents.Add(field);
            return field;
        }

        public virtual bool IsCommentsValid(out string message)
        {
            var isValid = !string.IsNullOrEmpty(Comments);
            message = "";
            if (!isValid)
                message = "message comments不可為空";
            return isValid;
        }

        public virtual bool IsNameValid(out string message)
        {
            var isValid = !string.IsNullOrEmpty(Name);
            message = "";
            if (!isValid)
                message = "message name不可為空";
            return isValid;
        }

        public void RemoveField(ProtoMessageFieldContent protoMessageFieldContent)
        {
            _protoMessageFieldContents.Remove(protoMessageFieldContent);
        }

        public override string ToString()
        {
            int number = 0;
            foreach (var protoMessageFieldContent in _protoMessageFieldContents)
                protoMessageFieldContent.SetNumber(++number);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"// {Comments}");
            sb.AppendLine($"message {Name} {{");
            sb.AppendLine(string.Join(Environment.NewLine, _protoMessageFieldContents));
            sb.AppendLine("}");
            foreach (var protoMessageFieldContents in _protoMessageFieldContents)
            {
                if (protoMessageFieldContents.Object != null)
                {
                    sb.AppendLine(protoMessageFieldContents.Object.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
