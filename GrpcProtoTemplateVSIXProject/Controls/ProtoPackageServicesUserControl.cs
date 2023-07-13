using GrpcProtoTemplateVSIXProject.Datas;
using System;
using System.Windows.Forms;

namespace GrpcProtoTemplateVSIXProject.Controls
{
    public partial class ProtoPackageServicesUserControl : UserControl
    {
        private ProtoPackageContent _package;
        private Action<bool, ProtoServiceContent> _updateSelectedService;
        private ProtoServiceContent _selectedService;

        public ProtoPackageServicesUserControl()
        {
            InitializeComponent();

            FlowLayoutPanelFillColumn.SetFillColumn(ServiceList);
        }

        public void Initialize(ProtoPackageContent package,
            Action<bool, ProtoServiceContent> updateSelectedService)
        {
            Clear();

            _package = package;
            _updateSelectedService = updateSelectedService;

            if (_package == null)
                return;

            foreach (var service in _package.ProtoServiceContents)
                ServiceList.Controls.Add(ProtoServiceItemUserControl.Create(
                    service, _package, ServiceList, UpdateSelectedService));
        }

        public void Clear()
        {
            _package = null;
            _selectedService = null;
            _updateSelectedService = null;

            ServiceList.Controls.Clear();
        }

        public void UpdateSelectedService(ProtoServiceContent newSelectedService)
        {
            var updateChildren = newSelectedService != _selectedService;
            _selectedService = newSelectedService;
            _updateSelectedService?.Invoke(updateChildren, _selectedService);

            foreach (var control in ServiceList.Controls)
            {
                if (control is ProtoServiceItemUserControl protoServiceItemUserControl)
                {
                    if (protoServiceItemUserControl.Service == newSelectedService)
                        protoServiceItemUserControl.SetSelectedColor();
                    else
                        protoServiceItemUserControl.SetUnselectedColor();
                }
            }
        }

        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            var service = _package.AddService();
            ServiceList.Controls.Add(ProtoServiceItemUserControl.Create(
                service, _package, ServiceList, UpdateSelectedService));
        }
    }
}
