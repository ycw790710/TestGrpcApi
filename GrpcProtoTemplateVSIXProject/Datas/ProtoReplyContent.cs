namespace GrpcProtoTemplateVSIXProject.Datas
{
    public class ProtoReplyContent : ProtoMessageContent
    {

        public override bool IsCommentsValid(out string message)
        {
            var isValid = !string.IsNullOrEmpty(Comments);
            message = "";
            if (!isValid)
                message = "reply comments不可為空";
            return isValid;
        }

        public override bool IsNameValid(out string message)
        {
            var isValid = !string.IsNullOrEmpty(Name);
            message = "";
            if (!isValid)
                message = "reply name不可為空";
            return isValid;
        }

    }
}
