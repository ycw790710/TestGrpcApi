namespace GrpcProtoTemplateVSIXProject.Controls
{
    partial class ProtoMessageUserControl
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
            this.FieldsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FieldsLabel = new System.Windows.Forms.Label();
            this.AddFieldButton = new System.Windows.Forms.Button();
            this.FieldList = new System.Windows.Forms.FlowLayoutPanel();
            this.TopLayout = new System.Windows.Forms.TableLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CommentsLabel = new System.Windows.Forms.Label();
            this.CommentsTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MainLayout.SuspendLayout();
            this.FieldsLayout.SuspendLayout();
            this.TopLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.FieldsLayout, 0, 1);
            this.MainLayout.Controls.Add(this.TopLayout, 0, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MainLayout.ForeColor = System.Drawing.Color.White;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(2);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 2;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Size = new System.Drawing.Size(377, 383);
            this.MainLayout.TabIndex = 10;
            // 
            // FieldsLayout
            // 
            this.FieldsLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FieldsLayout.ColumnCount = 1;
            this.FieldsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FieldsLayout.Controls.Add(this.FieldsLabel, 0, 0);
            this.FieldsLayout.Controls.Add(this.AddFieldButton, 0, 1);
            this.FieldsLayout.Controls.Add(this.FieldList, 0, 2);
            this.FieldsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldsLayout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FieldsLayout.Location = new System.Drawing.Point(1, 94);
            this.FieldsLayout.Margin = new System.Windows.Forms.Padding(1);
            this.FieldsLayout.Name = "FieldsLayout";
            this.FieldsLayout.RowCount = 3;
            this.FieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FieldsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FieldsLayout.Size = new System.Drawing.Size(375, 288);
            this.FieldsLayout.TabIndex = 1;
            // 
            // FieldsLabel
            // 
            this.FieldsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FieldsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldsLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FieldsLabel.Location = new System.Drawing.Point(3, 0);
            this.FieldsLabel.Name = "FieldsLabel";
            this.FieldsLabel.Size = new System.Drawing.Size(369, 30);
            this.FieldsLabel.TabIndex = 0;
            this.FieldsLabel.Text = "fields";
            this.FieldsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddFieldButton
            // 
            this.AddFieldButton.BackColor = System.Drawing.Color.MediumBlue;
            this.AddFieldButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddFieldButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.AddFieldButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.AddFieldButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.AddFieldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFieldButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AddFieldButton.Location = new System.Drawing.Point(0, 30);
            this.AddFieldButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddFieldButton.Name = "AddFieldButton";
            this.AddFieldButton.Size = new System.Drawing.Size(375, 30);
            this.AddFieldButton.TabIndex = 1;
            this.AddFieldButton.Text = "Add";
            this.AddFieldButton.UseVisualStyleBackColor = false;
            this.AddFieldButton.Click += new System.EventHandler(this.AddFieldButton_Click);
            // 
            // FieldList
            // 
            this.FieldList.AutoScroll = true;
            this.FieldList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FieldList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FieldList.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FieldList.Location = new System.Drawing.Point(0, 60);
            this.FieldList.Margin = new System.Windows.Forms.Padding(0);
            this.FieldList.Name = "FieldList";
            this.FieldList.Size = new System.Drawing.Size(375, 228);
            this.FieldList.TabIndex = 2;
            this.FieldList.WrapContents = false;
            // 
            // TopLayout
            // 
            this.TopLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TopLayout.ColumnCount = 2;
            this.TopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopLayout.Controls.Add(this.NameLabel, 0, 1);
            this.TopLayout.Controls.Add(this.MessageLabel, 0, 0);
            this.TopLayout.Controls.Add(this.NameTextBox, 1, 1);
            this.TopLayout.Controls.Add(this.CommentsLabel, 0, 2);
            this.TopLayout.Controls.Add(this.CommentsTextBox, 1, 2);
            this.TopLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopLayout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TopLayout.Location = new System.Drawing.Point(0, 0);
            this.TopLayout.Margin = new System.Windows.Forms.Padding(0);
            this.TopLayout.Name = "TopLayout";
            this.TopLayout.RowCount = 3;
            this.TopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TopLayout.Size = new System.Drawing.Size(377, 93);
            this.TopLayout.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameLabel.Location = new System.Drawing.Point(0, 25);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(120, 34);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MessageLabel
            // 
            this.TopLayout.SetColumnSpan(this.MessageLabel, 2);
            this.MessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MessageLabel.Location = new System.Drawing.Point(0, 0);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MessageLabel.MinimumSize = new System.Drawing.Size(0, 25);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(377, 25);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "message";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.Black;
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameTextBox.ForeColor = System.Drawing.Color.White;
            this.NameTextBox.Location = new System.Drawing.Point(120, 25);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(257, 28);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            this.NameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameTextBox_Validating);
            // 
            // CommentsLabel
            // 
            this.CommentsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommentsLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CommentsLabel.Location = new System.Drawing.Point(0, 59);
            this.CommentsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CommentsLabel.MinimumSize = new System.Drawing.Size(120, 0);
            this.CommentsLabel.Name = "CommentsLabel";
            this.CommentsLabel.Size = new System.Drawing.Size(120, 34);
            this.CommentsLabel.TabIndex = 2;
            this.CommentsLabel.Text = "Comments";
            this.CommentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CommentsTextBox
            // 
            this.CommentsTextBox.BackColor = System.Drawing.Color.Black;
            this.CommentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommentsTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CommentsTextBox.ForeColor = System.Drawing.Color.White;
            this.CommentsTextBox.Location = new System.Drawing.Point(120, 59);
            this.CommentsTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.CommentsTextBox.Name = "CommentsTextBox";
            this.CommentsTextBox.Size = new System.Drawing.Size(257, 28);
            this.CommentsTextBox.TabIndex = 3;
            this.CommentsTextBox.TextChanged += new System.EventHandler(this.CommentsTextBox_TextChanged);
            this.CommentsTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CommentsTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // ProtoMessageUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.MainLayout);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProtoMessageUserControl";
            this.Size = new System.Drawing.Size(377, 383);
            this.MainLayout.ResumeLayout(false);
            this.FieldsLayout.ResumeLayout(false);
            this.TopLayout.ResumeLayout(false);
            this.TopLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FieldList;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TableLayoutPanel FieldsLayout;
        private System.Windows.Forms.Label FieldsLabel;
        private System.Windows.Forms.Button AddFieldButton;
        private System.Windows.Forms.TableLayoutPanel TopLayout;
        public System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label CommentsLabel;
        private System.Windows.Forms.TextBox CommentsTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
