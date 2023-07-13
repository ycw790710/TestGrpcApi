using System.Text;

namespace GrpcProtoTemplateVSIXProject.Datas
{
    public class ProtoMethodContent
    {
        public string Comments { get; set; }

        public string Name { get; set; }

        public ProtoRequestContent ProtoRequestContent { get; private set; }
        public ProtoReplyContent ProtoReplyContent { get; private set; }

        public ProtoMethodContent()
        {
            ProtoRequestContent = new ProtoRequestContent();
            ProtoReplyContent = new ProtoReplyContent();
        }

        public bool IsCommentsValid(out string message)
        {
            var isValid = !string.IsNullOrEmpty(Comments);
            message = "";
            if (!isValid)
                message = "method comments不可為空";
            return isValid;
        }

        public bool IsNameValid(out string message)
        {
            var isValid = !string.IsNullOrEmpty(Name);
            message = "";
            if (!isValid)
                message = "method name不可為空";
            return isValid;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"// {Comments}");
            sb.AppendLine($"rpc {Name} ({ProtoRequestContent.Name}) returns ({ProtoReplyContent.Name});");
            return sb.ToString();
        }
    }
}
