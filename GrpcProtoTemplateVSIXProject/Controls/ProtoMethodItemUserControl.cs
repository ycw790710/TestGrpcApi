using GrpcProtoTemplateVSIXProject.Datas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GrpcProtoTemplateVSIXProject.Controls
{
    public partial class ProtoMethodItemUserControl : UserControl
    {
        private ProtoMethodContent _method;
        public ProtoMethodContent Method => _method;
        private ProtoServiceContent _parent;
        private Control _controlParent;
        private Action<ProtoMethodContent> _updateSelectedMethod;

        private Color _defaultBackColor;
        private Color _selectedBackColor;
        private readonly List<Control> _backControls;

        public ProtoMethodItemUserControl()
        {
            InitializeComponent();

            TextBoxClearButton.AddClearButton(NameTextBox);
            TextBoxClearButton.AddClearButton(CommentsTextBox);

            _defaultBackColor = Color.FromArgb(25, 25, 25);
            _selectedBackColor = Color.FromArgb(75, 75, 75);

            foreach (Control control in GetControls.RecursivelyGet(this, new HashSet<Type>() { typeof(Button) }))
                control.Click += Control_Click;

            _backControls = new List<Control>() { MainLayout, NameLabel, CommentsLabel };
            this.Disposed += ProtoMethodItemUserControl_Disposed;
        }

        private void ProtoMethodItemUserControl_Disposed(object sender, EventArgs e)
        {
            _backControls.Clear();
            Clear();
        }

        private void Control_Click(object sender, EventArgs e)
        {
            _updateSelectedMethod?.Invoke(_method);
        }

        public void SetSelectedColor()
        {
            foreach (Control control in _backControls)
                control.BackColor = _selectedBackColor;
        }

        public void SetUnselectedColor()
        {
            foreach (Control control in _backControls)
                control.BackColor = _defaultBackColor;
        }

        public static ProtoMethodItemUserControl Create(ProtoMethodContent method,
            ProtoServiceContent parent,
            Control controlParent,
            Action<ProtoMethodContent> updateSelectedMethod)
        {
            var protoMethodItemUserControl = new ProtoMethodItemUserControl();
            protoMethodItemUserControl.Initialize(method, parent, controlParent,
                updateSelectedMethod);
            return protoMethodItemUserControl;
        }

        public void Initialize(ProtoMethodContent method,
            ProtoServiceContent parent,
            Control controlParent,
            Action<ProtoMethodContent> updateSelectedMethod)
        {
            Clear();

            _method = method;
            _parent = parent;
            _controlParent = controlParent;
            _updateSelectedMethod = updateSelectedMethod;

            CommentsTextBox.Text = method.Comments;
            NameTextBox.Text = method.Name;
        }

        public void Clear()
        {
            _method = null;
            _parent = null;
            _controlParent = null;
            _updateSelectedMethod = null;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_method == null)
                return;
            _method.Name = NameTextBox.Text;
        }

        private void CommentsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_method == null)
                return;
            _method.Comments = CommentsTextBox.Text;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _parent.RemoveMethod(_method);
            _controlParent.Controls.Remove(this);
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
