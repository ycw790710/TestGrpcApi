using System.Text;

namespace GrpcProtoTemplateVSIXProject.Datas
{
    public class ProtoMessageFieldContent
    {
        public string Comments { get; set; }

        public string Name { get; set; }

        public int Number { get; private set; }

        public ProtoMessageFieldLabel ProtoMessageFieldLabel { get; private set; }

        public ProtoMessageFieldType Type { get; private set; }

        private ProtoMessageContent _object;
        public ProtoMessageContent Object => _object;

        public ProtoMessageFieldContent()
        {
            ProtoMessageFieldLabel = ProtoMessageFieldLabel.none;
            Type = ProtoMessageFieldType.String;
        }

        public virtual bool IsCommentsValid(out string message)
        {
            var isValid = !string.IsNullOrEmpty(Comments);
            message = "";
            if (!isValid)
                message = "field comments不可為空";
            return isValid;
        }

        public virtual bool IsNameValid(out string message)
        {
            var isValid = !string.IsNullOrEmpty(Name);
            message = "";
            if (!isValid)
                message = "field name不可為空";
            return isValid;
        }

        public void SetNumber(int number)
        {
            Number = number;
        }

        public void SetProtoMessageFieldLabel(ProtoMessageFieldLabel label)
        {
            ProtoMessageFieldLabel = label;
        }

        public void SetProtoMessageFieldType(ProtoMessageFieldType type)
        {
            Type = type;
            if (Type == ProtoMessageFieldType.message)
                _object = new ProtoMessageContent();
            else
                _object = null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"// {Comments}");
            if (ProtoMessageFieldLabel != null)
                sb.Append($"{ProtoMessageFieldLabel} ");
            if (Type != ProtoMessageFieldType.message)
                sb.Append($"{Type} {Name} = {Number};");
            else
                sb.Append($"{_object.Name} {Name} = {Number};");
            return sb.ToString();
        }
    }
}
