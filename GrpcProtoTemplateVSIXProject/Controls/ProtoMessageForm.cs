using GrpcProtoTemplateVSIXProject.Datas;
using System;
using System.Windows.Forms;

namespace GrpcProtoTemplateVSIXProject.Controls
{
    public partial class ProtoMessageForm : Form
    {
        public ProtoMessageForm()
        {
            InitializeComponent();

            FormLayout.UseImmersiveDarkMode(this.Handle, true);

        }

        public void Initialize(ProtoMessageContent protoMessageContent)
        {
            ProtoMessageControl.Initialize(protoMessageContent);
        }

    }
}
