namespace GrpcProtoTemplateVSIXProject.Controls
{
    partial class ProtoMessageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProtoMessageControl = new GrpcProtoTemplateVSIXProject.Controls.ProtoMessageUserControl();
            this.SuspendLayout();
            // 
            // ProtoMessageControl
            // 
            this.ProtoMessageControl.BackColor = System.Drawing.Color.Black;
            this.ProtoMessageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProtoMessageControl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ProtoMessageControl.ForeColor = System.Drawing.Color.White;
            this.ProtoMessageControl.Location = new System.Drawing.Point(0, 0);
            this.ProtoMessageControl.Margin = new System.Windows.Forms.Padding(0);
            this.ProtoMessageControl.MessageLabelText = "message";
            this.ProtoMessageControl.Name = "ProtoMessageControl";
            this.ProtoMessageControl.Size = new System.Drawing.Size(415, 412);
            this.ProtoMessageControl.TabIndex = 0;
            // 
            // ProtoMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(415, 412);
            this.Controls.Add(this.ProtoMessageControl);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ProtoMessageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ProtoMessageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ProtoMessageUserControl ProtoMessageControl;
    }
}