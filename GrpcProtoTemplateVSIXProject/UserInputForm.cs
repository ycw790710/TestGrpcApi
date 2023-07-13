using GrpcProtoTemplateVSIXProject.Controls;
using GrpcProtoTemplateVSIXProject.Datas;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GrpcProtoTemplateVSIXProject
{
    public partial class UserInputForm : Form
    {
        public string package { get; private set; }
        public string package_content { get; private set; }
        public string csharp_namespace { get; private set; }

        private ProtoPackageContent packageContent;

        public UserInputForm()
        {
            InitializeComponent();

            FormLayout.UseImmersiveDarkMode(this.Handle, true);

            packageContent = new ProtoPackageContent();

            this.RequestControl.Visible = false;
            this.ReplyControl.Visible = false;
            this.ServiceMethodsControl.Visible = false;

        }

        public void Initialize(string fileName = "TestPackage")
        {
            packageContent.Name = fileName;

            PackageControl.Initialize(packageContent);
            PackageServicesControl.Initialize(packageContent, UpdateSelectedService);

            CsharpNamespaceControl.Initialize();
        }

        #region  Package

        #endregion


        #region CsharpNameSpace

        #endregion


        #region Service
        private void UpdateSelectedService(bool updateChildren, ProtoServiceContent selectedService)
        {
            if (updateChildren)
            {
                RequestControl.Clear();
                ReplyControl.Clear();
                ServiceMethodsControl.Initialize(selectedService, UpdateSelectedMethod);
                this.ServiceMethodsControl.Visible = selectedService != null;
                this.RequestControl.Visible = false;
                this.ReplyControl.Visible = false;
            }
        }
        #endregion


        #region Method
        private void UpdateSelectedMethod(bool updateChildren, ProtoMethodContent selectedMethod)
        {
            if (updateChildren)
            {
                RequestControl.Initialize(selectedMethod.ProtoRequestContent);
                ReplyControl.Initialize(selectedMethod.ProtoReplyContent);
                this.RequestControl.Visible = true;
                this.ReplyControl.Visible = true;
            }
        }
        #endregion


        #region Request

        #endregion


        #region Reply

        #endregion


        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                package = packageContent.Name;
                package_content = packageContent.ToString();
                csharp_namespace = CsharpNamespaceControl.Value;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("驗證失敗");
            }
        }

    }
}
