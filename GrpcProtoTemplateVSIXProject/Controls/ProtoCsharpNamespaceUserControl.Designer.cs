namespace GrpcProtoTemplateVSIXProject.Controls
{
    partial class ProtoCsharpNamespaceUserControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.ValueLabel, 0, 0);
            this.MainLayout.Controls.Add(this.ValueTextBox, 1, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(2);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 1;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayout.Size = new System.Drawing.Size(393, 29);
            this.MainLayout.TabIndex = 8;
            // 
            // ValueLabel
            // 
            this.ValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueLabel.Location = new System.Drawing.Point(0, 0);
            this.ValueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(200, 33);
            this.ValueLabel.TabIndex = 0;
            this.ValueLabel.Text = "csharpNameSpace";
            this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.BackColor = System.Drawing.Color.Black;
            this.ValueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueTextBox.ForeColor = System.Drawing.Color.White;
            this.ValueTextBox.Location = new System.Drawing.Point(200, 0);
            this.ValueTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(193, 28);
            this.ValueTextBox.TabIndex = 1;
            this.ValueTextBox.TextChanged += new System.EventHandler(this.ValueTextBox_TextChanged);
            this.ValueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValueTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // ProtoCsharpNamespaceUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.MainLayout);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProtoCsharpNamespaceUserControl";
            this.Size = new System.Drawing.Size(393, 29);
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
