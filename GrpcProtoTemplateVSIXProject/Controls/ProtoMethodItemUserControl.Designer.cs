namespace GrpcProtoTemplateVSIXProject.Controls
{
    partial class ProtoMethodItemUserControl
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.CommentsLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CommentsTextBox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MainLayout.ColumnCount = 3;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.Controls.Add(this.NameLabel, 0, 0);
            this.MainLayout.Controls.Add(this.CommentsLabel, 0, 1);
            this.MainLayout.Controls.Add(this.NameTextBox, 1, 0);
            this.MainLayout.Controls.Add(this.CommentsTextBox, 1, 1);
            this.MainLayout.Controls.Add(this.RemoveButton, 2, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(2);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 2;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayout.Size = new System.Drawing.Size(288, 67);
            this.MainLayout.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Location = new System.Drawing.Point(3, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(110, 34);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CommentsLabel
            // 
            this.CommentsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommentsLabel.Location = new System.Drawing.Point(3, 34);
            this.CommentsLabel.Name = "CommentsLabel";
            this.CommentsLabel.Size = new System.Drawing.Size(110, 36);
            this.CommentsLabel.TabIndex = 1;
            this.CommentsLabel.Text = "Comments";
            this.CommentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.Black;
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTextBox.ForeColor = System.Drawing.Color.White;
            this.NameTextBox.Location = new System.Drawing.Point(117, 1);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(150, 28);
            this.NameTextBox.TabIndex = 4;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            this.NameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameTextBox_Validating);
            // 
            // CommentsTextBox
            // 
            this.CommentsTextBox.BackColor = System.Drawing.Color.Black;
            this.CommentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommentsTextBox.ForeColor = System.Drawing.Color.White;
            this.CommentsTextBox.Location = new System.Drawing.Point(117, 35);
            this.CommentsTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.CommentsTextBox.Name = "CommentsTextBox";
            this.CommentsTextBox.Size = new System.Drawing.Size(150, 28);
            this.CommentsTextBox.TabIndex = 5;
            this.CommentsTextBox.TextChanged += new System.EventHandler(this.CommentsTextBox_TextChanged);
            this.CommentsTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CommentsTextBox_Validating);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.RemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.ForeColor = System.Drawing.Color.White;
            this.RemoveButton.Location = new System.Drawing.Point(269, 1);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(1);
            this.RemoveButton.Name = "RemoveButton";
            this.MainLayout.SetRowSpan(this.RemoveButton, 2);
            this.RemoveButton.Size = new System.Drawing.Size(18, 68);
            this.RemoveButton.TabIndex = 8;
            this.RemoveButton.Text = "x";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // ProtoMethodItemUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.MainLayout);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProtoMethodItemUserControl";
            this.Size = new System.Drawing.Size(288, 67);
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CommentsLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox CommentsTextBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
