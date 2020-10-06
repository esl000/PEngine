using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class ClassPresetMaker : Form
    {
        public NameCodePair Current { get;}

        public ClassPresetMaker(NameCodePair current)
        {
            InitializeComponent();

            Current = current;

            Core.OpenEditorForms.Add(this);

            ClassFormNameTextArea.Text = Current.name;
            HeaderTextEditor.Text = Current.header;
            SourceTextEditor.Text = Current.implement;

            ClassFormSaveButton.Text = ClassFormNameTextArea.Text.Length == 0 ? "Save *" : "Save";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Core.OpenEditorForms.Remove(this);
        }

        private void ClassFormSaveButton_Click(object sender, EventArgs e)
        {
            if(ClassFormNameTextArea.Text.Length == 0)
            {
                MessageBox.Show("Cannot save without class form name!", "Save Error", MessageBoxButtons.OK);
                return;
            }

            List<NameCodePair> comparers = Core.AllData.ClassFormData.FindAll((c) => c.name == ClassFormNameTextArea.Text);

            if (comparers.Count > 1 ||
                (comparers.Count == 1 && comparers[0] != Current))
            {
                MessageBox.Show("Alleady exist this name. please change name", "Save Error", MessageBoxButtons.OK);
                return;
            }

            Current.name = ClassFormNameTextArea.Text;
            Current.header = HeaderTextEditor.Text;
            Current.implement = SourceTextEditor.Text;
            ClassFormSaveButton.Text = "Save";

            Core.UpdateClassFormList();
        }

        private void ClassFormDeleteButton_Click(object sender, EventArgs e)
        {
            Core.AllData.ClassFormData.Remove(Current);
            Core.UpdateClassFormList();
            Close();
        }

        private void ClassFormNameTextArea_TextChanged(object sender, EventArgs e)
        {
            ClassFormSaveButton.Text = "Save *";
        }

        private void HeaderTextEditor_TextChanged(object sender, EventArgs e)
        {
            ClassFormSaveButton.Text = "Save *";
        }

        private void SourceTextEditor_TextChanged(object sender, EventArgs e)
        {
            ClassFormSaveButton.Text = "Save *";
        }
    }
}
