using System;
using System.Windows.Forms;

namespace GrpcProtoTemplateVSIXProject.Controls
{
    internal class FlowLayoutPanelFillColumn
    {
        public static void SetFillColumn(FlowLayoutPanel flowLayoutPanel)
        {
            flowLayoutPanel.SizeChanged += FlowLayoutPanel_SizeChanged;
        }

        private static void FlowLayoutPanel_SizeChanged(object sender, EventArgs e)
        {
            if (sender is FlowLayoutPanel flowLayoutPanel)
            {
                flowLayoutPanel.SuspendLayout();
                foreach (Control control in flowLayoutPanel.Controls)
                    control.Width = flowLayoutPanel.ClientSize.Width;
                flowLayoutPanel.ResumeLayout();
            }
        }
    }
}
