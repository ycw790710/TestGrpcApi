using System;
using System.Drawing;
using System.Windows.Forms;

namespace GrpcProtoTemplateVSIXProject.Controls
{
    internal class TextBoxClearButton
    {
        public static void AddClearButton(TextBox textBox)
        {
            var clearButton = new Button();
            clearButton.Width = 20;
            clearButton.Dock = DockStyle.Right;
            clearButton.Text = "x";
            clearButton.TextAlign = ContentAlignment.MiddleCenter;
            clearButton.Margin = new Padding(0, 0, 0, 0);
            clearButton.Tag = textBox;
            clearButton.Font = new Font(textBox.Font.FontFamily, 10, FontStyle.Regular);
            clearButton.BackColor = Color.FromArgb(192, 0, 0);
            clearButton.FlatAppearance.BorderColor = Color.Red;
            clearButton.FlatAppearance.MouseDownBackColor =Color.Maroon;
            clearButton.FlatAppearance.MouseOverBackColor = Color.Red;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.ForeColor = Color.White;
            clearButton.UseVisualStyleBackColor = false;

            clearButton.Click += Btn_Click;
            clearButton.GotFocus += Btn_GotFocus;

            textBox.Controls.Add(clearButton);

            // https://stackoverflow.com/questions/15868817/button-inside-a-winforms-textbox
            SendMessage(textBox.Handle, 0xd3, (IntPtr)2, (IntPtr)(clearButton.Width << 16));
        }

        private static void Btn_GotFocus(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                ((TextBox)button.Tag).Focus();
            }
        }

        private static void Btn_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                ((TextBox)button.Tag).Text = "";
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

    }
}
