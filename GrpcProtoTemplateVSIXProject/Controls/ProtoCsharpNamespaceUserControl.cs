using System;
using System.Drawing;
using System.Windows.Forms;

namespace GrpcProtoTemplateVSIXProject.Controls
{
    public partial class ProtoCsharpNamespaceUserControl : UserControl
    {
        public string Value;

        public ProtoCsharpNamespaceUserControl()
        {
            InitializeComponent();

            TextBoxClearButton.AddClearButton(ValueTextBox);
        }

        public void Initialize(string val = "TestNameSpace")
        {
            Clear();

            ValueTextBox.Text = val;
            Value = val;
        }

        public void Clear()
        {
            ValueTextBox.Text = "";
            Value = "";
        }

        private void ValueTextBox_TextChanged(object sender, EventArgs e)
        {
            Value = ValueTextBox.Text;
        }

        private void ValueTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                TextBoxValidating.ValidateNotEmpty(textBox, e, errorProvider1);
            }
        }
    }
}
