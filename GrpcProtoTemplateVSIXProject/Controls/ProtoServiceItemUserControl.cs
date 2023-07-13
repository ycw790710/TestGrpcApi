using GrpcProtoTemplateVSIXProject.Datas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GrpcProtoTemplateVSIXProject.Controls
{
    public partial class ProtoServiceItemUserControl : UserControl
    {
        private Action<ProtoServiceContent> _updateSelectedService;
        private ProtoServiceContent _service;
        public ProtoServiceContent Service => _service;
        private ProtoPackageContent _parent;
        private Control _controlParent;

        private Color _defaultBackColor;
        private Color _selectedBackColor;
        private readonly List<Control> _backControls;

        public ProtoServiceItemUserControl()
        {
            InitializeComponent();

            TextBoxClearButton.AddClearButton(NameTextBox);
            TextBoxClearButton.AddClearButton(CommentsTextBox);

            _defaultBackColor = Color.FromArgb(25, 25, 25);
            _selectedBackColor = Color.FromArgb(75, 75, 75);

            foreach (Control control in GetControls.RecursivelyGet(this, new HashSet<Type>() { typeof(Button) }))
                control.Click += Control_Click;
            _backControls = new List<Control>() { MainLayout, NameLabel, CommentsLabel };
            this.Disposed += ProtoServiceItemUserControl_Disposed;
        }

        private void ProtoServiceItemUserControl_Disposed(object sender, EventArgs e)
        {
            _backControls.Clear();
            Clear();
        }

        private void Control_Click(object sender, EventArgs e)
        {
            _updateSelectedService?.Invoke(_service);
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

        public static ProtoServiceItemUserControl Create(ProtoServiceContent service,
            ProtoPackageContent parent,
            Control controlParent,
            Action<ProtoServiceContent> updateSelectedService)
        {
            var protoServiceItemUserControl = new ProtoServiceItemUserControl();
            protoServiceItemUserControl.Initialize(service, parent, controlParent,
                updateSelectedService);
            return protoServiceItemUserControl;
        }

        public void Initialize(ProtoServiceContent service,
            ProtoPackageContent parent,
            Control controlParent,
            Action<ProtoServiceContent> updateSelectedService)
        {
            Clear();

            _service = service;
            _parent = parent;
            _controlParent = controlParent;
            _updateSelectedService = updateSelectedService;

            CommentsTextBox.Text = service.Comments;
            NameTextBox.Text = service.Name;
        }

        public void Clear()
        {
            _service = null;
            _parent = null;
            _controlParent = null;
            _updateSelectedService = null;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_service == null)
                return;
            _service.Name = NameTextBox.Text;
        }

        private void CommentsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_service == null)
                return;
            _service.Comments = CommentsTextBox.Text;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _parent.RemoveService(_service);
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
