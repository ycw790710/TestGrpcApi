using GrpcProtoTemplateVSIXProject.Datas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GrpcProtoTemplateVSIXProject.Controls
{
    public partial class ProtoFieldItemUserControl : UserControl
    {
        private ProtoMessageFieldContent _field;
        public ProtoMessageFieldContent Field => _field;
        private ProtoMessageContent _parent;
        private Control _parentControl;
        private Action<ProtoMessageFieldContent> _updateSelectedField;

        private readonly List<Control> _backControls;
        private Color _defaultBackColor;
        private Color _selectedBackColor;

        public ProtoFieldItemUserControl()
        {
            InitializeComponent();

            TextBoxClearButton.AddClearButton(NameTextBox);
            TextBoxClearButton.AddClearButton(CommentsTextBox);

            _defaultBackColor = Color.FromArgb(25, 25, 25);
            _selectedBackColor = Color.FromArgb(75, 75, 75);

            ComboBoxDraw.SetComboBoxDraw(LabelCombobox);
            var protoMessageFieldLabeleList = ProtoMessageFieldLabel.GetAll();
            foreach (var protoMessageFieldLabel in protoMessageFieldLabeleList)
                LabelCombobox.Items.Add(protoMessageFieldLabel);

            ComboBoxDraw.SetComboBoxDraw(TypeCombobox);
            var protoMessageFieldTypeList = ProtoMessageFieldType.GetAll();
            foreach (var protoMessageFieldType in protoMessageFieldTypeList)
                TypeCombobox.Items.Add(protoMessageFieldType);

            foreach (Control control in GetControls.RecursivelyGet(this, new HashSet<Type>() { typeof(Button) }))
                control.Click += Control_Click;

            _backControls = new List<Control>() { MainLayout, NameLabel, CommentsLabel, TypeLabel, LabelLabel };

            this.Disposed += ProtoFieldItemUserControl_Disposed;
        }

        private void ProtoFieldItemUserControl_Disposed(object sender, EventArgs e)
        {
            _backControls.Clear();
            Clear();            
        }

        private void Control_Click(object sender, EventArgs e)
        {
            _updateSelectedField?.Invoke(_field);
        }

        public void SetSelected()
        {
            foreach (Control control in _backControls)
                control.BackColor = _selectedBackColor;
        }

        public void SetUnselected()
        {
            foreach (Control control in _backControls)
                control.BackColor = _defaultBackColor;
        }

        public static ProtoFieldItemUserControl Create(
            ProtoMessageFieldContent field, ProtoMessageContent parent, Control parentControl,
            Action<ProtoMessageFieldContent> updateSelectedField)
        {
            ProtoFieldItemUserControl fieldItemUserControl = new ProtoFieldItemUserControl();
            fieldItemUserControl.Initialize(field, parent, parentControl, updateSelectedField);
            return fieldItemUserControl;
        }

        public void Initialize(
            ProtoMessageFieldContent field, ProtoMessageContent parent, Control parentControl,
            Action<ProtoMessageFieldContent> updateSelectedField)
        {
            Clear();

            _field = field;
            _parent = parent;
            _parentControl = parentControl;
            _updateSelectedField = updateSelectedField;

            CommentsTextBox.Text = field.Comments;
            NameTextBox.Text = field.Name;
            TypeCombobox.SelectedItem = field.Type;
            LabelCombobox.SelectedItem = field.ProtoMessageFieldLabel;
        }

        public void Clear()
        {
            _field = null;
            _parent = null;
            _parentControl = null;

            OpenNestMessageButton.Enabled = false;
            OpenNestMessageButton.Visible = false;
            CommentsTextBox.Text = "";
            NameTextBox.Text = "";
            TypeCombobox.SelectedIndex = -1;
            LabelCombobox.SelectedIndex = -1;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_field == null)
                return;
            if (sender is TextBox textBox)
                _field.Name = textBox.Text;
        }

        private void CommentsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_field == null)
                return;
            if (sender is TextBox textBox)
                _field.Comments = textBox.Text;
        }

        private void LabelCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_field == null)
                return;
            if (sender is ComboBox comboBox)
            {
                var selectedItem = (ProtoMessageFieldLabel)comboBox.SelectedItem;
                _field.SetProtoMessageFieldLabel(selectedItem);
            }
        }

        private void TypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_field == null)
                return;
            if (sender is ComboBox comboBox)
            {
                var selectedItem = (ProtoMessageFieldType)comboBox.SelectedItem;
                _field.SetProtoMessageFieldType(selectedItem);
                if (selectedItem == ProtoMessageFieldType.message)
                {
                    OpenNestMessageButton.Enabled = true;
                    OpenNestMessageButton.Visible = true;
                }
                else
                {
                    OpenNestMessageButton.Enabled = false;
                    OpenNestMessageButton.Visible = false;
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (_field == null || _parentControl == null || _parent == null)
                return;
            _parent.RemoveField(_field);
            _parentControl.Controls.Remove(this);
        }

        private void OpenNestMessageButton_Click(object sender, EventArgs e)
        {
            if (_field == null)
                return;
            if (sender is Button button)
            {
                var protoMessageForm = new ProtoMessageForm();
                protoMessageForm.Initialize(_field.Object);
                protoMessageForm.ShowDialog();
            }
        }

        private void NameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                TextBoxValidating.ValidateNotEmpty(textBox, e, errorProvider1);
            }
        }

        private void CommentsTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                TextBoxValidating.ValidateNotEmpty(textBox, e, errorProvider1);
            }
        }
    }
}
