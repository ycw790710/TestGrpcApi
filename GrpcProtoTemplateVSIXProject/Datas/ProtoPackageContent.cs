using System;
using System.Collections.Generic;
using System.Text;

namespace GrpcProtoTemplateVSIXProject.Datas
{
    public class ProtoPackageContent
    {
        public string Name { get; set; }

        private readonly List<ProtoServiceContent> _protoServiceContents;
        public IReadOnlyList<ProtoServiceContent> ProtoServiceContents => _protoServiceContents;

        public ProtoPackageContent()
        {
            _protoServiceContents = new List<ProtoServiceContent>();
        }

        public ProtoServiceContent AddService()
        {
            var service = new ProtoServiceContent();
            _protoServiceContents.Add(service);
            return service;
        }

        public void RemoveService(ProtoServiceContent protoServiceContent)
        {
            _protoServiceContents.Remove(protoServiceContent);
        }

        public bool IsNameValid(out string message)
        {
            var isValid = !string.IsNullOrEmpty(Name);
            message = "";
            if (!isValid)
                message = "package不可為空";
            return isValid;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Environment.NewLine);
            sb.AppendLine(string.Join(Environment.NewLine, _protoServiceContents));
            return sb.ToString();
        }
    }
}
