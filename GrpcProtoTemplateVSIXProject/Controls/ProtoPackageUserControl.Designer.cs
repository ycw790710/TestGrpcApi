namespace GrpcProtoTemplateVSIXProject.Controls
{
    partial class ProtoPackageUserControl
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
            this.PackageTextBox = new System.Windows.Forms.TextBox();
            this.PackageLabel = new System.Windows.Forms.Label();
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
            this.MainLayout.Controls.Add(this.PackageTextBox, 0, 0);
            this.MainLayout.Controls.Add(this.PackageLabel, 0, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(2);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 1;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayout.Size = new System.Drawing.Size(437, 33);
            this.MainLayout.TabIndex = 7;
            // 
            // PackageTextBox
            // 
            this.PackageTextBox.BackColor = System.Drawing.Color.Black;
            this.PackageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PackageTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PackageTextBox.ForeColor = System.Drawing.Color.White;
            this.PackageTextBox.Location = new System.Drawing.Point(100, 0);
            this.PackageTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.PackageTextBox.Name = "PackageTextBox";
            this.PackageTextBox.Size = new System.Drawing.Size(337, 28);
            this.PackageTextBox.TabIndex = 3;
            this.PackageTextBox.TextChanged += new System.EventHandler(this.PackageTextBox_TextChanged);
            this.PackageTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PackageTextBox_Validating);
            // 
            // PackageLabel
            // 
            this.PackageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PackageLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PackageLabel.Location = new System.Drawing.Point(0, 0);
            this.PackageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PackageLabel.Name = "PackageLabel";
            this.PackageLabel.Size = new System.Drawing.Size(100, 34);
            this.PackageLabel.TabIndex = 2;
            this.PackageLabel.Text = "package";
            this.PackageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // ProtoPackageUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.MainLayout);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProtoPackageUserControl";
            this.Size = new System.Drawing.Size(437, 33);
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.Label PackageLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox PackageTextBox;
    }
}
