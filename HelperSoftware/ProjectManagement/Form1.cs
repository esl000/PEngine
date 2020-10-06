using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassGeneratorCore;

namespace ProjectManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ProjectDirectoryText.Text = Core.AllData.ProjectDirectory;
            ProjectSourceDirectoryText.Text = Core.AllData.ProjectSourceDirectory;
            ProjectOutputDirectoryText.Text = Core.AllData.ProjectOutputDirectory;

            TargetDirectoryTextArea.Text = Core.AllData.LastClassWizardSearchPath;
            UpdateClassFormList();
        }

        public string GetPrefixFolder()
        {
            if (PublicToggle.Checked)
                return "Public";
            else
                return "Private";
        }

        public void UpdateClassFormList()
        {
            int preIndex = ClassFormListBox.SelectedIndex;
            int preSize = ClassFormListBox.Items.Count;

            ClassFormListBox.ClearSelected();
            ClassFormListBox.Items.Clear();

            foreach(var pair in Core.AllData.ClassFormData)
            {
                ClassFormListBox.Items.Add(pair.name);
            }

            if (ClassFormListBox.Items.Count > 0)
            {
                if (preSize != ClassFormListBox.Items.Count)
                    preIndex = preSize - ClassFormListBox.Items.Count > 0 ? preIndex - 1 : preIndex + 1;

                if (preIndex < 0)
                    preIndex = 0;

                if (preIndex > ClassFormListBox.Items.Count - 1)
                    preIndex = ClassFormListBox.Items.Count - 1;

                ClassFormListBox.SelectedIndex = preIndex;
            }
        }

        private void ChangeProjectDirectory_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog())
            {
                openFileDialog.IsFolderPicker = true;
                openFileDialog.InitialDirectory = ProjectDirectoryText.Text.Length == 0 ? "" : ProjectDirectoryText.Text;
                CommonFileDialogResult result = openFileDialog.ShowDialog();

                if (result == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
                {
                    ProjectDirectoryText.Text = openFileDialog.FileName;
                    Core.AllData.ProjectDirectory = openFileDialog.FileName;
                }
            }
        }

        private void ChangeProjectSourceDirectory_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog())
            {
                openFileDialog.IsFolderPicker = true;
                openFileDialog.InitialDirectory = ProjectSourceDirectoryText.Text.Length == 0 ? "" : ProjectSourceDirectoryText.Text;
                CommonFileDialogResult result = openFileDialog.ShowDialog();

                if (result == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
                {
                    ProjectSourceDirectoryText.Text = openFileDialog.FileName;
                    Core.AllData.ProjectSourceDirectory = openFileDialog.FileName;
                }
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            Core.GenerateProjectSolution();
        }

        private void ChangeTargetDirectory_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog())
            {
                openFileDialog.IsFolderPicker = true;
                openFileDialog.InitialDirectory = TargetDirectoryTextArea.Text.Length == 0 ?
                    Core.AllData.ProjectSourceDirectory : TargetDirectoryTextArea.Text;
                CommonFileDialogResult result = openFileDialog.ShowDialog();

                if (result == CommonFileDialogResult.Ok &&
                    !string.IsNullOrWhiteSpace(openFileDialog.FileName))
                {
                    DirectoryInfo di = new DirectoryInfo(openFileDialog.FileName);

                    if (di.GetFiles("*.Target.cs").Length > 0)
                    {
                        TargetDirectoryTextArea.Text = openFileDialog.FileName;
                        Core.AllData.LastClassWizardSearchPath = openFileDialog.FileName;
                        return;
                    }
                }
            }

            TargetDirectoryTextArea.Text = "";
            HeaderFileDirectoryTextArea.Text = "";
        }

        private void CreateClass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ClassNameTextArea.Text) ||
                string.IsNullOrWhiteSpace(TargetDirectoryTextArea.Text) ||
                string.IsNullOrWhiteSpace(HeaderFileDirectoryTextArea.Text))
                return;

            NameCodePair pair = Core.AllData.ClassFormData.Find((p) => p.name == ParentClassNameTextArea.Text);

            string relativePath = CMakeCore.CMakeUtility.GetRelativePath(Path.Combine(TargetDirectoryTextArea.Text, GetPrefixFolder()),
                HeaderFileDirectoryTextArea.Text, '\\');

            string headerPath = HeaderFileDirectoryTextArea.Text;
            string implementPath = Path.Combine(TargetDirectoryTextArea.Text, "Private" , relativePath);

            string moduleName = new DirectoryInfo(TargetDirectoryTextArea.Text).Name; 

            if (pair == null)
                ClassGenerator.CreateDefaultClass(ClassNameTextArea.Text, ParentClassNameTextArea.Text, headerPath, implementPath);
            else
                ClassGenerator.CreateClassWithClassForm(ClassNameTextArea.Text, ParentClassNameTextArea.Text, moduleName, new List<string>() {
                   pair.header,
                   pair.implement
                }
                , headerPath, implementPath);

            ClassNameTextArea.Clear();
            ParentClassNameTextArea.Text = "";
        }

        private void CreateClassAndGenerate_Click(object sender, EventArgs e)
        {
            CreateClass_Click(sender, e);
            Core.GenerateProjectSolution();
        }

        private void CreateClassForm_Click(object sender, EventArgs e)
        {
            NameCodePair pair = new NameCodePair();
            pair.name = "NewClassForm";

            if(Core.AllData.ClassFormData.Find((f) => f.name == pair.name) == null)
            {
                Core.AllData.ClassFormData.Add(pair);
                UpdateClassFormList();
                ClassFormListBox.SelectedIndex = ClassFormListBox.Items.Count - 1;
                return;
            }

            int index = 1;

            while(true)
            {
                if(Core.AllData.ClassFormData.Find((f)=>f.name == pair.name + index) == null)
                {
                    pair.name = pair.name + index;
                    Core.AllData.ClassFormData.Add(pair);
                    UpdateClassFormList();
                    return;
                }
                ++index;
            }
        }

        private void DeleteClassForm_Click(object sender, EventArgs e)
        {
            if (ClassFormListBox.SelectedIndex < 0 ||
                ClassFormListBox.SelectedIndex >= ClassFormListBox.Items.Count)
                return;

            string name = (string)ClassFormListBox.Items[ClassFormListBox.SelectedIndex];
            NameCodePair pair = Core.AllData.ClassFormData.Find((f) => f.name == name);

            ClassPresetMaker form = Core.OpenEditorForms.Find((f) => f.Current == pair);

            if(form != null)
            {
                form.Close();
            }

            Core.AllData.ClassFormData.Remove(pair);
            UpdateClassFormList();
        }

        private void OpenClassFormEditor_Click(object sender, EventArgs e)
        {
            if (ClassFormListBox.SelectedIndex < 0 ||
                ClassFormListBox.SelectedIndex >= ClassFormListBox.Items.Count)
                return;

            string name = (string)ClassFormListBox.Items[ClassFormListBox.SelectedIndex];
            NameCodePair pair = Core.AllData.ClassFormData.Find((f) => f.name == name);

            ClassPresetMaker form = Core.OpenEditorForms.Find((f) => f.Current == pair);

            if (form != null)
            {
                form.Activate();
                return;
            }

            form = new ClassPresetMaker(pair);

            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void ClassFormListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClassFormListBox.SelectedIndex < 0 ||
                ClassFormListBox.SelectedIndex >= ClassFormListBox.Items.Count)
            {
                HeaderCodeView.Text = "";
                SourceCodeView.Text = "";
                return;
            }

            string name = (string)ClassFormListBox.Items[ClassFormListBox.SelectedIndex];
            NameCodePair pair = Core.AllData.ClassFormData.Find((f) => f.name == name);

            HeaderCodeView.Text = pair.header;
            SourceCodeView.Text = pair.implement;
        }

        private void SeletePresetClass_Click(object sender, EventArgs e)
        {
            ClassPresetSelectDialog form = 
                new ClassPresetSelectDialog((value) => ParentClassNameTextArea.Text = value);

            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void MakePublicFolder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TargetDirectoryTextArea.Text))
                return;

            DirectoryInfo publicFolder = new DirectoryInfo(
                Path.Combine(TargetDirectoryTextArea.Text, "Public"));

            DirectoryInfo privateFolder = new DirectoryInfo(
                Path.Combine(TargetDirectoryTextArea.Text, "Private"));

            if (!publicFolder.Exists) publicFolder.Create();
            if (!privateFolder.Exists) privateFolder.Create();
        }

        private void PublicToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(HeaderFileDirectoryTextArea.Text))
                return;

            string relativePath = CMakeCore.CMakeUtility.GetRelativePath(TargetDirectoryTextArea.Text,
                HeaderFileDirectoryTextArea.Text, '\\');

            string publicToken = "Public", privateToken = "Private";

            if (relativePath.IndexOf(publicToken) > -1 && relativePath.Length > publicToken.Length + 1)
                relativePath = relativePath.Substring(publicToken.Length + 1);
            else if (relativePath.IndexOf(privateToken) > -1 && relativePath.Length > privateToken.Length + 1)
                relativePath = relativePath.Substring(privateToken.Length + 1);
            else
                relativePath = string.Empty;

            HeaderFileDirectoryTextArea.Text = Path.Combine(TargetDirectoryTextArea.Text, GetPrefixFolder(), relativePath);
        }

        private void PrivateToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(HeaderFileDirectoryTextArea.Text))
                return;

            string relativePath = CMakeCore.CMakeUtility.GetRelativePath(TargetDirectoryTextArea.Text,
                HeaderFileDirectoryTextArea.Text, '\\');

            string publicToken = "Public", privateToken = "Private";

            if (relativePath.IndexOf(publicToken) > -1 && relativePath.Length > publicToken.Length + 1)
                relativePath = relativePath.Substring(publicToken.Length + 1);
            else if (relativePath.IndexOf(privateToken) > -1 && relativePath.Length > privateToken.Length + 1)
                relativePath = relativePath.Substring(privateToken.Length + 1);
            else
                relativePath = string.Empty;

            HeaderFileDirectoryTextArea.Text = Path.Combine(TargetDirectoryTextArea.Text, GetPrefixFolder(), relativePath);
        }

        private void ChangeHeaderDirectory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TargetDirectoryTextArea.Text))
                return;
            
            using (CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog())
            {
                openFileDialog.IsFolderPicker = true;
                openFileDialog.InitialDirectory = HeaderFileDirectoryTextArea.Text.Length == 0 ? 
                    TargetDirectoryTextArea.Text : HeaderFileDirectoryTextArea.Text;
                CommonFileDialogResult result = openFileDialog.ShowDialog();

                if (result == CommonFileDialogResult.Ok && 
                    !string.IsNullOrWhiteSpace(openFileDialog.FileName))
                {
                    DirectoryInfo di = new DirectoryInfo(openFileDialog.FileName);

                    if(openFileDialog.FileName.IndexOf(
                        Path.Combine(TargetDirectoryTextArea.Text, GetPrefixFolder())) > -1)
                    {
                        HeaderFileDirectoryTextArea.Text = openFileDialog.FileName;
                        return;
                    }
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ChangeModuleTargetDirectory_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog())
            {
                openFileDialog.IsFolderPicker = true;
                openFileDialog.InitialDirectory = string.IsNullOrWhiteSpace(ModuleTargetDirectoryTextArea.Text) ?
                    Core.AllData.ProjectSourceDirectory : ModuleTargetDirectoryTextArea.Text;
                CommonFileDialogResult result = openFileDialog.ShowDialog();

                if (result == CommonFileDialogResult.Ok &&
                    !string.IsNullOrWhiteSpace(openFileDialog.FileName))
                {
                    ModuleTargetDirectoryTextArea.Text = openFileDialog.FileName;
                }
            }
        }

        private void CreateModule_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ModuleNameTextArea.Text) ||
                string.IsNullOrWhiteSpace(ModuleTargetDirectoryTextArea.Text))
                return;

            ModuleGenerator.CreateModule(ModuleTargetDirectoryTextArea.Text, ModuleNameTextArea.Text);
        }

        private void CreateAndGenerateModule_Click(object sender, EventArgs e)
        {
            CreateModule_Click(sender, e);
            Core.GenerateProjectSolution();
        }
    }
}
