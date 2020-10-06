using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateClassWizard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //class name
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateClass();
        }

        private void CreateClass()
        {
            if (textBox1.Text.Length == 0)
                return;

            string className = textBox1.Text;
            string parentClassName = textBox2.Text;

            bool isInheritToCreate = parentClassName.Length == 0 ? false : true;

            string header = "";
            header += "#pragma once\n\n";
            header += isInheritToCreate ? 
                ("#include <" + parentClassName + ".h>\n\n\n\n") : "\n\n\n\n";
            header += "class " + className + (isInheritToCreate ?
                (" : public " + parentClassName + "\n") : "\n");
            header += "{\n\n";
            header += "public:\n";
            header += "\t" + className + "();\n";
            header += "\t~" + className + "();\n\n";
            header += "};\n";

            string implementCode = "";
            implementCode += "#include <" + className + ".h>\n\n\n\n";
            implementCode += className + "::" + className + "()\n";
            implementCode += isInheritToCreate ? ("\t: " + parentClassName + "()\n") : "";
            implementCode += "{\n\n\n";
            implementCode += "}\n\n";
            implementCode += className + "::~" + className + "()\n";
            implementCode += "{\n\n\n";
            implementCode += "}\n\n";

            DirectoryInfo di = new DirectoryInfo(textBox3.Text);

            if(!di.Exists)
            {
                di.Create();
            }

            File.WriteAllText(di.FullName + "\\" + className + ".h", header);
            File.WriteAllText(di.FullName + "\\" + className + ".cpp", implementCode);

            Process process = new Process();
            process.StartInfo.FileName = Directory.GetCurrentDirectory() + "\\generator.bat";
            process.Start();

            textBox1.Text = "";
            textBox2.Text = "";
        }

        //parent class name
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openFileDialog = new FolderBrowserDialog())
            {
                openFileDialog.ShowNewFolderButton = true;
                openFileDialog.SelectedPath =  textBox3.Text.Length == 0 ? Directory.GetCurrentDirectory() : textBox3.Text;
                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.SelectedPath))
                {
                    textBox3.Text = openFileDialog.SelectedPath;
                }
            }
        }
    }
}
