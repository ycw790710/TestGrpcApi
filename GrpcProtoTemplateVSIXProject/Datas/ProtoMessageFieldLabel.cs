using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GrpcProtoTemplateVSIXProject.Datas
{
    public class ProtoMessageFieldLabel
    {
        public static ProtoMessageFieldLabel none = new ProtoMessageFieldLabel("");
        public static ProtoMessageFieldLabel optional = new ProtoMessageFieldLabel("optional");
        public static ProtoMessageFieldLabel repeated = new ProtoMessageFieldLabel("repeated");

        public string SyntaxName { get; private set; }
        public ProtoMessageFieldLabel(string syntaxName)
        {
            SyntaxName = syntaxName;
        }

        public static IEnumerable<ProtoMessageFieldLabel> GetAll() =>
            typeof(ProtoMessageFieldLabel).GetFields(BindingFlags.Public |
                                BindingFlags.Static |
                                BindingFlags.DeclaredOnly)
                        .Select(f => f.GetValue(null))
                        .Cast<ProtoMessageFieldLabel>();

        public static ProtoMessageFieldLabel FromSyntaxName(string syntaxName)
        {
            return GetAll().FirstOrDefault(item => item.SyntaxName == syntaxName);
        }

        public override string ToString()
        {
            return SyntaxName;
        }
    }
}
