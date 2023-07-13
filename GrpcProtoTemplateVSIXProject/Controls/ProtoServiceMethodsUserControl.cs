using GrpcProtoTemplateVSIXProject.Datas;
using System;
using System.Windows.Forms;

namespace GrpcProtoTemplateVSIXProject.Controls
{
    public partial class ProtoServiceMethodsUserControl : UserControl
    {
        private ProtoServiceContent _service;
        private ProtoMethodContent _selectedMethod;
        private Action<bool, ProtoMethodContent> _updateSelectedMethod;

        public ProtoServiceMethodsUserControl()
        {
            InitializeComponent();

            FlowLayoutPanelFillColumn.SetFillColumn(MethodList);
        }

        public void Initialize(ProtoServiceContent service,
            Action<bool, ProtoMethodContent> updateSelectedMethod)
        {
            Clear();

            _service = service;
            _updateSelectedMethod = updateSelectedMethod;

            if (_service == null)
                return;

            foreach (var method in _service.ProtoMethodContents)
                MethodList.Controls.Add(ProtoMethodItemUserControl.Create(
                    method, _service, MethodList, UpdateSelectedMethod));
        }

        public void Clear()
        {
            _selectedMethod = null;
            _service = null;
            _updateSelectedMethod = null;

            MethodList.Controls.Clear();
        }

        private void UpdateSelectedMethod(ProtoMethodContent newSelectedMethod)
        {
            var updateChildren = newSelectedMethod != _selectedMethod;
            _selectedMethod = newSelectedMethod;
            _updateSelectedMethod?.Invoke(updateChildren, _selectedMethod);

            foreach (var control in MethodList.Controls)
            {
                if (control is ProtoMethodItemUserControl protoMethodItemUserControl)
                {
                    if (protoMethodItemUserControl.Method == newSelectedMethod)
                        protoMethodItemUserControl.SetSelectedColor();
                    else
                        protoMethodItemUserControl.SetUnselectedColor();
                }
            }
        }

        private void AddMethodButton_Click(object sender, EventArgs e)
        {
            if (_service == null)
                return;

            var method = _service.AddMethod();
            MethodList.Controls.Add(ProtoMethodItemUserControl.Create(
                method, _service, MethodList, UpdateSelectedMethod));
        }
    }
}
