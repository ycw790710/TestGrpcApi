namespace GrpcProtoTemplateVSIXProject
{
    partial class UserInputForm
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
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TopLayout = new System.Windows.Forms.SplitContainer();
            this.PackageControl = new GrpcProtoTemplateVSIXProject.Controls.ProtoPackageUserControl();
            this.CsharpNamespaceControl = new GrpcProtoTemplateVSIXProject.Controls.ProtoCsharpNamespaceUserControl();
            this.ContentLayout = new System.Windows.Forms.SplitContainer();
            this.ContentLeftLayout = new System.Windows.Forms.SplitContainer();
            this.PackageServicesControl = new GrpcProtoTemplateVSIXProject.Controls.ProtoPackageServicesUserControl();
            this.ServiceMethodsControl = new GrpcProtoTemplateVSIXProject.Controls.ProtoServiceMethodsUserControl();
            this.ContentRightLayout = new System.Windows.Forms.SplitContainer();
            this.RequestControl = new GrpcProtoTemplateVSIXProject.Controls.ProtoMessageUserControl();
            this.ReplyControl = new GrpcProtoTemplateVSIXProject.Controls.ProtoMessageUserControl();
            this.MainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopLayout)).BeginInit();
            this.TopLayout.Panel1.SuspendLayout();
            this.TopLayout.Panel2.SuspendLayout();
            this.TopLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContentLayout)).BeginInit();
            this.ContentLayout.Panel1.SuspendLayout();
            this.ContentLayout.Panel2.SuspendLayout();
            this.ContentLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContentLeftLayout)).BeginInit();
            this.ContentLeftLayout.Panel1.SuspendLayout();
            this.ContentLeftLayout.Panel2.SuspendLayout();
            this.ContentLeftLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContentRightLayout)).BeginInit();
            this.ContentRightLayout.Panel1.SuspendLayout();
            this.ContentRightLayout.Panel2.SuspendLayout();
            this.ContentRightLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SubmitBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.SubmitBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubmitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.SubmitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.SubmitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Location = new System.Drawing.Point(1, 548);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(1, 5, 1, 1);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(1346, 34);
            this.SubmitBtn.TabIndex = 0;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1091F));
            this.MainLayout.Controls.Add(this.TopLayout, 0, 0);
            this.MainLayout.Controls.Add(this.SubmitBtn, 0, 2);
            this.MainLayout.Controls.Add(this.ContentLayout, 0, 1);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.MainLayout.Size = new System.Drawing.Size(1348, 583);
            this.MainLayout.TabIndex = 1;
            // 
            // TopLayout
            // 
            this.TopLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopLayout.Location = new System.Drawing.Point(3, 3);
            this.TopLayout.Name = "TopLayout";
            // 
            // TopLayout.Panel1
            // 
            this.TopLayout.Panel1.Controls.Add(this.PackageControl);
            this.TopLayout.Panel1MinSize = 100;
            // 
            // TopLayout.Panel2
            // 
            this.TopLayout.Panel2.Controls.Add(this.CsharpNamespaceControl);
            this.TopLayout.Panel2MinSize = 100;
            this.TopLayout.Size = new System.Drawing.Size(1342, 34);
            this.TopLayout.SplitterDistance = 497;
            this.TopLayout.TabIndex = 2;
            // 
            // PackageControl
            // 
            this.PackageControl.BackColor = System.Drawing.Color.Black;
            this.PackageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PackageControl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PackageControl.ForeColor = System.Drawing.Color.White;
            this.PackageControl.Location = new System.Drawing.Point(0, 0);
            this.PackageControl.Margin = new System.Windows.Forms.Padding(0);
            this.PackageControl.Name = "PackageControl";
            this.PackageControl.Size = new System.Drawing.Size(497, 34);
            this.PackageControl.TabIndex = 7;
            // 
            // CsharpNamespaceControl
            // 
            this.CsharpNamespaceControl.BackColor = System.Drawing.Color.Black;
            this.CsharpNamespaceControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CsharpNamespaceControl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CsharpNamespaceControl.ForeColor = System.Drawing.Color.White;
            this.CsharpNamespaceControl.Location = new System.Drawing.Point(0, 0);
            this.CsharpNamespaceControl.Margin = new System.Windows.Forms.Padding(0);
            this.CsharpNamespaceControl.Name = "CsharpNamespaceControl";
            this.CsharpNamespaceControl.Size = new System.Drawing.Size(841, 34);
            this.CsharpNamespaceControl.TabIndex = 8;
            // 
            // ContentLayout
            // 
            this.ContentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentLayout.Location = new System.Drawing.Point(3, 43);
            this.ContentLayout.Name = "ContentLayout";
            // 
            // ContentLayout.Panel1
            // 
            this.ContentLayout.Panel1.Controls.Add(this.ContentLeftLayout);
            // 
            // ContentLayout.Panel2
            // 
            this.ContentLayout.Panel2.Controls.Add(this.ContentRightLayout);
            this.ContentLayout.Size = new System.Drawing.Size(1342, 497);
            this.ContentLayout.SplitterDistance = 505;
            this.ContentLayout.TabIndex = 3;
            // 
            // ContentLeftLayout
            // 
            this.ContentLeftLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentLeftLayout.Location = new System.Drawing.Point(0, 0);
            this.ContentLeftLayout.Name = "ContentLeftLayout";
            // 
            // ContentLeftLayout.Panel1
            // 
            this.ContentLeftLayout.Panel1.Controls.Add(this.PackageServicesControl);
            // 
            // ContentLeftLayout.Panel2
            // 
            this.ContentLeftLayout.Panel2.Controls.Add(this.ServiceMethodsControl);
            this.ContentLeftLayout.Size = new System.Drawing.Size(505, 497);
            this.ContentLeftLayout.SplitterDistance = 251;
            this.ContentLeftLayout.TabIndex = 2;
            // 
            // PackageServicesControl
            // 
            this.PackageServicesControl.BackColor = System.Drawing.Color.Black;
            this.PackageServicesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PackageServicesControl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PackageServicesControl.ForeColor = System.Drawing.Color.White;
            this.PackageServicesControl.Location = new System.Drawing.Point(0, 0);
            this.PackageServicesControl.Margin = new System.Windows.Forms.Padding(0);
            this.PackageServicesControl.Name = "PackageServicesControl";
            this.PackageServicesControl.Size = new System.Drawing.Size(251, 497);
            this.PackageServicesControl.TabIndex = 7;
            // 
            // ServiceMethodsControl
            // 
            this.ServiceMethodsControl.BackColor = System.Drawing.Color.Black;
            this.ServiceMethodsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceMethodsControl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ServiceMethodsControl.ForeColor = System.Drawing.Color.White;
            this.ServiceMethodsControl.Location = new System.Drawing.Point(0, 0);
            this.ServiceMethodsControl.Margin = new System.Windows.Forms.Padding(0);
            this.ServiceMethodsControl.Name = "ServiceMethodsControl";
            this.ServiceMethodsControl.Size = new System.Drawing.Size(250, 497);
            this.ServiceMethodsControl.TabIndex = 0;
            // 
            // ContentRightLayout
            // 
            this.ContentRightLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentRightLayout.Location = new System.Drawing.Point(0, 0);
            this.ContentRightLayout.Name = "ContentRightLayout";
            // 
            // ContentRightLayout.Panel1
            // 
            this.ContentRightLayout.Panel1.Controls.Add(this.RequestControl);
            // 
            // ContentRightLayout.Panel2
            // 
            this.ContentRightLayout.Panel2.Controls.Add(this.ReplyControl);
            this.ContentRightLayout.Size = new System.Drawing.Size(833, 497);
            this.ContentRightLayout.SplitterDistance = 417;
            this.ContentRightLayout.TabIndex = 3;
            // 
            // RequestControl
            // 
            this.RequestControl.BackColor = System.Drawing.Color.Black;
            this.RequestControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RequestControl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RequestControl.ForeColor = System.Drawing.Color.White;
            this.RequestControl.Location = new System.Drawing.Point(0, 0);
            this.RequestControl.Margin = new System.Windows.Forms.Padding(0);
            this.RequestControl.MessageLabelText = "request";
            this.RequestControl.Name = "RequestControl";
            this.RequestControl.Size = new System.Drawing.Size(417, 497);
            this.RequestControl.TabIndex = 0;
            // 
            // ReplyControl
            // 
            this.ReplyControl.BackColor = System.Drawing.Color.Black;
            this.ReplyControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReplyControl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ReplyControl.ForeColor = System.Drawing.Color.White;
            this.ReplyControl.Location = new System.Drawing.Point(0, 0);
            this.ReplyControl.Margin = new System.Windows.Forms.Padding(0);
            this.ReplyControl.MessageLabelText = "reply";
            this.ReplyControl.Name = "ReplyControl";
            this.ReplyControl.Size = new System.Drawing.Size(412, 497);
            this.ReplyControl.TabIndex = 0;
            // 
            // UserInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1348, 583);
            this.Controls.Add(this.MainLayout);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserInputForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "UserInputForm";
            this.MainLayout.ResumeLayout(false);
            this.TopLayout.Panel1.ResumeLayout(false);
            this.TopLayout.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopLayout)).EndInit();
            this.TopLayout.ResumeLayout(false);
            this.ContentLayout.Panel1.ResumeLayout(false);
            this.ContentLayout.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContentLayout)).EndInit();
            this.ContentLayout.ResumeLayout(false);
            this.ContentLeftLayout.Panel1.ResumeLayout(false);
            this.ContentLeftLayout.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContentLeftLayout)).EndInit();
            this.ContentLeftLayout.ResumeLayout(false);
            this.ContentRightLayout.Panel1.ResumeLayout(false);
            this.ContentRightLayout.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContentRightLayout)).EndInit();
            this.ContentRightLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.SplitContainer TopLayout;
        private System.Windows.Forms.SplitContainer ContentLeftLayout;
        private System.Windows.Forms.SplitContainer ContentRightLayout;
        private System.Windows.Forms.SplitContainer ContentLayout;
        private Controls.ProtoMessageUserControl RequestControl;
        private Controls.ProtoMessageUserControl ReplyControl;
        private Controls.ProtoServiceMethodsUserControl ServiceMethodsControl;
        private Controls.ProtoPackageServicesUserControl PackageServicesControl;
        private Controls.ProtoPackageUserControl PackageControl;
        private Controls.ProtoCsharpNamespaceUserControl CsharpNamespaceControl;
    }
}