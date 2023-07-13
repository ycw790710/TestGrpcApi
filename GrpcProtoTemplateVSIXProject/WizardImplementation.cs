using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TemplateWizard;
using System.Windows.Forms;
using EnvDTE;
using System.IO;

namespace GrpcProtoTemplateVSIXProject
{
    public class WizardImplementation : IWizard
    {
        private bool _hasNewProjectItem = true;

        // This method is called before opening any item that
        // has the OpenInEditor attribute.
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        // This method is only called for item templates,
        // not for project templates.
        public void ProjectItemFinishedGenerating(ProjectItem
            projectItem)
        {
        }

        // This method is called after the project is created.
        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            if (!replacementsDictionary["$rootname$"].EndsWith(".proto"))
                replacementsDictionary["$rootname$"] = $"{replacementsDictionary["$rootname$"]}.proto";
            
            try
            {
                var inputFileName = replacementsDictionary["$rootname$"];
                var inputForm = new UserInputForm();
                inputForm.Text = inputFileName;
                inputForm.Initialize(inputFileName.Replace(".proto", ""));
                if (inputForm.ShowDialog() != DialogResult.OK)
                {
                    _hasNewProjectItem = false;

                    throw new WizardCancelledException();
                }

                replacementsDictionary.Add("$package$", inputForm.package);
                replacementsDictionary.Add("$package_content$", inputForm.package_content);
                replacementsDictionary.Add("$csharp_namespace$", inputForm.csharp_namespace);
            }
            catch (WizardCancelledException)
            {
                // for new project template
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return _hasNewProjectItem;
        }
    }
}
