namespace GrpcProtoTemplateVSIXProject.Datas
{
    public class ProtoRequestContent : ProtoMessageContent
    {

        public override bool IsCommentsValid(out string message)
        {
            var isValid = !string.IsNullOrEmpty(Comments);
            message = "";
            if (!isValid)
                message = "request comments不可為空";
            return isValid;
        }

        public override bool IsNameValid(out string message)
        {
            var isValid = !string.IsNullOrEmpty(Name);
            message = "";
            if (!isValid)
                message = "request name不可為空";
            return isValid;
        }
    }
}
