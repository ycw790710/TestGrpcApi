namespace GrpcProtoTemplateVSIXProject.Controls
{
    partial class ProtoPackageServicesUserControl
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
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ServiceList = new System.Windows.Forms.FlowLayoutPanel();
            this.AddServiceButton = new System.Windows.Forms.Button();
            this.ServicesLabel = new System.Windows.Forms.Label();
            this.MainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.ServiceList, 0, 2);
            this.MainLayout.Controls.Add(this.AddServiceButton, 0, 1);
            this.MainLayout.Controls.Add(this.ServicesLabel, 0, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MainLayout.ForeColor = System.Drawing.Color.White;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(2);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Size = new System.Drawing.Size(383, 360);
            this.MainLayout.TabIndex = 7;
            // 
            // ServiceList
            // 
            this.ServiceList.AutoScroll = true;
            this.ServiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ServiceList.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ServiceList.Location = new System.Drawing.Point(0, 60);
            this.ServiceList.Margin = new System.Windows.Forms.Padding(0);
            this.ServiceList.Name = "ServiceList";
            this.ServiceList.Size = new System.Drawing.Size(383, 300);
            this.ServiceList.TabIndex = 3;
            this.ServiceList.WrapContents = false;
            // 
            // AddServiceButton
            // 
            this.AddServiceButton.BackColor = System.Drawing.Color.MediumBlue;
            this.AddServiceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddServiceButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.AddServiceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.AddServiceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.AddServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddServiceButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AddServiceButton.Location = new System.Drawing.Point(0, 30);
            this.AddServiceButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddServiceButton.Name = "AddServiceButton";
            this.AddServiceButton.Size = new System.Drawing.Size(383, 30);
            this.AddServiceButton.TabIndex = 2;
            this.AddServiceButton.Text = "Add";
            this.AddServiceButton.UseVisualStyleBackColor = false;
            this.AddServiceButton.Click += new System.EventHandler(this.AddServiceButton_Click);
            // 
            // ServicesLabel
            // 
            this.ServicesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServicesLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ServicesLabel.Location = new System.Drawing.Point(0, 0);
            this.ServicesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ServicesLabel.Name = "ServicesLabel";
            this.ServicesLabel.Size = new System.Drawing.Size(383, 30);
            this.ServicesLabel.TabIndex = 0;
            this.ServicesLabel.Text = "services";
            this.ServicesLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ProtoPackageServicesUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.MainLayout);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProtoPackageServicesUserControl";
            this.Size = new System.Drawing.Size(383, 360);
            this.MainLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.FlowLayoutPanel ServiceList;
        private System.Windows.Forms.Button AddServiceButton;
        private System.Windows.Forms.Label ServicesLabel;
    }
}
