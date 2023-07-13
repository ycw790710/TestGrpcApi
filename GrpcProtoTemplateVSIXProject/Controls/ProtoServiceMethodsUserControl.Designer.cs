namespace GrpcProtoTemplateVSIXProject.Controls
{
    partial class ProtoServiceMethodsUserControl
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
            this.MethodLabel = new System.Windows.Forms.Label();
            this.AddMethodButton = new System.Windows.Forms.Button();
            this.MethodList = new System.Windows.Forms.FlowLayoutPanel();
            this.MainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.MethodLabel, 0, 0);
            this.MainLayout.Controls.Add(this.AddMethodButton, 0, 1);
            this.MainLayout.Controls.Add(this.MethodList, 0, 2);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(2);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Size = new System.Drawing.Size(237, 272);
            this.MainLayout.TabIndex = 6;
            // 
            // MethodLabel
            // 
            this.MethodLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MethodLabel.Location = new System.Drawing.Point(0, 0);
            this.MethodLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MethodLabel.Name = "MethodLabel";
            this.MethodLabel.Size = new System.Drawing.Size(237, 30);
            this.MethodLabel.TabIndex = 0;
            this.MethodLabel.Text = "methods";
            this.MethodLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // AddMethodButton
            // 
            this.AddMethodButton.BackColor = System.Drawing.Color.MediumBlue;
            this.AddMethodButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddMethodButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.AddMethodButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.AddMethodButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.AddMethodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMethodButton.Location = new System.Drawing.Point(0, 30);
            this.AddMethodButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddMethodButton.Name = "AddMethodButton";
            this.AddMethodButton.Size = new System.Drawing.Size(237, 30);
            this.AddMethodButton.TabIndex = 1;
            this.AddMethodButton.Text = "Add";
            this.AddMethodButton.UseVisualStyleBackColor = false;
            this.AddMethodButton.Click += new System.EventHandler(this.AddMethodButton_Click);
            // 
            // MethodList
            // 
            this.MethodList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MethodList.Location = new System.Drawing.Point(0, 60);
            this.MethodList.Margin = new System.Windows.Forms.Padding(0);
            this.MethodList.Name = "MethodList";
            this.MethodList.Size = new System.Drawing.Size(237, 212);
            this.MethodList.TabIndex = 2;
            // 
            // ProtoServiceMethodsUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.MainLayout);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProtoServiceMethodsUserControl";
            this.Size = new System.Drawing.Size(237, 272);
            this.MainLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.Label MethodLabel;
        private System.Windows.Forms.Button AddMethodButton;
        private System.Windows.Forms.FlowLayoutPanel MethodList;
    }
}
