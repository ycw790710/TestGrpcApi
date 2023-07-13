using GrpcProtoTemplateVSIXProject.Datas;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GrpcProtoTemplateVSIXProject.Controls
{
    public partial class ProtoMessageUserControl : UserControl
    {
        [Description("Message Label Text"), Category("Custom")]
        public string MessageLabelText
        {
            get => MessageLabel.Text;
            set => MessageLabel.Text = value;
        }

        private ProtoMessageContent _protoMessageContent;

        public ProtoMessageUserControl()
        {
            InitializeComponent();

            TextBoxClearButton.AddClearButton(NameTextBox);
            TextBoxClearButton.AddClearButton(CommentsTextBox);
            FlowLayoutPanelFillColumn.SetFillColumn(FieldList);
        }

        private void UpdateSelectedField(ProtoMessageFieldContent selectedField)
        {
            foreach (var control in FieldList.Controls)
            {
                if (control is ProtoFieldItemUserControl protoFieldItemUserControl)
                {
                    if (protoFieldItemUserControl.Field == selectedField)
                        protoFieldItemUserControl.SetSelected();
                    else
                        protoFieldItemUserControl.SetUnselected();
                }
            }
        }

        public void Initialize(ProtoMessageContent protoMessageContent)
        {
            Clear();

            _protoMessageContent = protoMessageContent;
            if (_protoMessageContent == null)
                return;

            this.NameTextBox.Text = protoMessageContent.Name;
            this.CommentsTextBox.Text = protoMessageContent.Comments;
            foreach (var field in _protoMessageContent.ProtoMessageFieldContents)
                FieldList.Controls.Add(ProtoFieldItemUserControl.Create(
                    field, _protoMessageContent, FieldList, UpdateSelectedField));
        }

        public void Clear()
        {
            _protoMessageContent = null;

            NameTextBox.Text = "";
            FieldList.Controls.Clear();
        }

        private void AddFieldButton_Click(object sender, EventArgs e)
        {
            if (_protoMessageContent == null)
                return;

            var field = _protoMessageContent.AddField();
            FieldList.Controls.Add(ProtoFieldItemUserControl.Create(
                field, _protoMessageContent, FieldList, UpdateSelectedField));
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_protoMessageContent == null)
                return;

            if (sender is TextBox textBox)
                _protoMessageContent.Name = textBox.Text;
        }

        private void CommentsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_protoMessageContent == null)
                return;

            if (sender is TextBox textBox)
                _protoMessageContent.Comments = textBox.Text;
        }

        private void NameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                TextBoxValidating.ValidateNotEmpty(textBox, e, errorProvider1);
            }
        }

        private void CommentsTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                TextBoxValidating.ValidateNotEmpty(textBox, e, errorProvider1);
            }
        }
    }
}
