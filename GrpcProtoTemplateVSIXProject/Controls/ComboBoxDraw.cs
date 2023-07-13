using System.Drawing;
using System.Windows.Forms;

namespace GrpcProtoTemplateVSIXProject.Controls
{
    internal static class ComboBoxDraw
    {
        public static void SetComboBoxDraw(System.Windows.Forms.ComboBox comboBox)
        {
            comboBox.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox.DrawItem += ComboBox_DrawItem;
        }
        private static void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1)
                return;
            if (sender is System.Windows.Forms.ComboBox comboBox)
            {
                e.DrawBackground();
                e.Graphics.DrawString(comboBox.Items[e.Index].ToString(), comboBox.Font, new SolidBrush(comboBox.ForeColor),
                    e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }
    }
}
