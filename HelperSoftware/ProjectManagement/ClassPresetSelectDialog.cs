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
    public partial class ClassPresetSelectDialog : Form
    {
        Action<string> SelectedValueGetter;

        public ClassPresetSelectDialog(Action<string> selectedValueGetter)
        {
            InitializeComponent();

            SelectedValueGetter = selectedValueGetter;
            UpdateClassFormList();
        }

        public void UpdateClassFormList()
        {
            ClassPresetListBox.ClearSelected();
            ClassPresetListBox.Items.Clear();

            foreach (var pair in Core.AllData.ClassFormData)
            {
                ClassPresetListBox.Items.Add(pair.name);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            SelectedValueGetter?.Invoke((string)ClassPresetListBox.Items[ClassPresetListBox.SelectedIndex]);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
