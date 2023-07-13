using System;
using System.Drawing;
using System.Windows.Forms;

namespace GrpcProtoTemplateVSIXProject.Controls
{
    internal class TextBoxValidating
    {
        public static void Validate(TextBox textBox, System.ComponentModel.CancelEventArgs e,
            ErrorProvider errorProvider, Func<string, string> validateFunc)
        {
            var errorMessage = validateFunc(textBox.Text);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                textBox.BackColor = Color.FromArgb(150, 50, 50);
                errorProvider.SetError(textBox, errorMessage);
                e.Cancel = true;
            }
            else
            {
                textBox.BackColor = Color.Black;
                errorProvider.SetError(textBox, "");
            }
        }
        public static void ValidateNotEmpty(TextBox textBox, System.ComponentModel.CancelEventArgs e,
            ErrorProvider errorProvider)
        {
            Validate(textBox, e, errorProvider, (text) =>
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    return "不能為空";
                return "";
            });
        }
    }
}
