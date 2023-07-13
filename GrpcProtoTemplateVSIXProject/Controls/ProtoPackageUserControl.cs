using GrpcProtoTemplateVSIXProject.Datas;
using System;
using System.Windows.Forms;

namespace GrpcProtoTemplateVSIXProject.Controls
{
    public partial class ProtoPackageUserControl : UserControl
    {
        private ProtoPackageContent _packageContent;

        public ProtoPackageUserControl()
        {
            InitializeComponent();

            TextBoxClearButton.AddClearButton(PackageTextBox);
        }

        public void Initialize(ProtoPackageContent packageContent)
        {
            Clear();

            _packageContent = packageContent;

            PackageTextBox.Text = _packageContent.Name;
        }

        public void Clear()
        {
            _packageContent = null;
            PackageTextBox.Text = "";
        }

        private void PackageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_packageContent == null)
                return;

            _packageContent.Name = PackageTextBox.Text;
        }

        private void PackageTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                TextBoxValidating.ValidateNotEmpty(textBox, e, errorProvider1);
            }
        }
    }
}
