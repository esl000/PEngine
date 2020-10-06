namespace ProjectManagement
{
    partial class ClassPresetMaker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClassFormNameTextArea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ClassFormDeleteButton = new System.Windows.Forms.Button();
            this.ClassFormSaveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.HeaderTab = new System.Windows.Forms.TabPage();
            this.HeaderTextEditor = new System.Windows.Forms.RichTextBox();
            this.SourceTab = new System.Windows.Forms.TabPage();
            this.SourceTextEditor = new System.Windows.Forms.RichTextBox();
            this.tabControl2.SuspendLayout();
            this.HeaderTab.SuspendLayout();
            this.SourceTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassFormNameTextArea
            // 
            this.ClassFormNameTextArea.Location = new System.Drawing.Point(12, 45);
            this.ClassFormNameTextArea.Name = "ClassFormNameTextArea";
            this.ClassFormNameTextArea.Size = new System.Drawing.Size(261, 21);
            this.ClassFormNameTextArea.TabIndex = 15;
            this.ClassFormNameTextArea.TextChanged += new System.EventHandler(this.ClassFormNameTextArea_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 48);
            this.label7.TabIndex = 13;
            this.label7.Text = "class name keyword : #classname#\r\nparent class name keyword : #parentclassname#\r\n" +
    "module name : #modulename#\r\nupper module name : #uppermodulename#";
            // 
            // ClassFormDeleteButton
            // 
            this.ClassFormDeleteButton.Location = new System.Drawing.Point(400, 45);
            this.ClassFormDeleteButton.Name = "ClassFormDeleteButton";
            this.ClassFormDeleteButton.Size = new System.Drawing.Size(79, 23);
            this.ClassFormDeleteButton.TabIndex = 12;
            this.ClassFormDeleteButton.Text = "Delete";
            this.ClassFormDeleteButton.UseVisualStyleBackColor = true;
            this.ClassFormDeleteButton.Click += new System.EventHandler(this.ClassFormDeleteButton_Click);
            // 
            // ClassFormSaveButton
            // 
            this.ClassFormSaveButton.Location = new System.Drawing.Point(299, 45);
            this.ClassFormSaveButton.Name = "ClassFormSaveButton";
            this.ClassFormSaveButton.Size = new System.Drawing.Size(79, 23);
            this.ClassFormSaveButton.TabIndex = 11;
            this.ClassFormSaveButton.Text = "Save";
            this.ClassFormSaveButton.UseVisualStyleBackColor = true;
            this.ClassFormSaveButton.Click += new System.EventHandler(this.ClassFormSaveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Class Presets";
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.HeaderTab);
            this.tabControl2.Controls.Add(this.SourceTab);
            this.tabControl2.Location = new System.Drawing.Point(12, 91);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(803, 542);
            this.tabControl2.TabIndex = 9;
            // 
            // HeaderTab
            // 
            this.HeaderTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderTab.Controls.Add(this.HeaderTextEditor);
            this.HeaderTab.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HeaderTab.Location = new System.Drawing.Point(4, 22);
            this.HeaderTab.Name = "HeaderTab";
            this.HeaderTab.Padding = new System.Windows.Forms.Padding(3);
            this.HeaderTab.Size = new System.Drawing.Size(795, 516);
            this.HeaderTab.TabIndex = 0;
            this.HeaderTab.Text = "Header";
            // 
            // HeaderTextEditor
            // 
            this.HeaderTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderTextEditor.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 10F);
            this.HeaderTextEditor.Location = new System.Drawing.Point(3, 3);
            this.HeaderTextEditor.Name = "HeaderTextEditor";
            this.HeaderTextEditor.Size = new System.Drawing.Size(789, 510);
            this.HeaderTextEditor.TabIndex = 0;
            this.HeaderTextEditor.Text = "";
            this.HeaderTextEditor.TextChanged += new System.EventHandler(this.HeaderTextEditor_TextChanged);
            // 
            // SourceTab
            // 
            this.SourceTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SourceTab.Controls.Add(this.SourceTextEditor);
            this.SourceTab.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SourceTab.Location = new System.Drawing.Point(4, 22);
            this.SourceTab.Name = "SourceTab";
            this.SourceTab.Padding = new System.Windows.Forms.Padding(3);
            this.SourceTab.Size = new System.Drawing.Size(795, 516);
            this.SourceTab.TabIndex = 1;
            this.SourceTab.Text = "Source";
            // 
            // SourceTextEditor
            // 
            this.SourceTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceTextEditor.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 10F);
            this.SourceTextEditor.Location = new System.Drawing.Point(3, 3);
            this.SourceTextEditor.Name = "SourceTextEditor";
            this.SourceTextEditor.Size = new System.Drawing.Size(789, 510);
            this.SourceTextEditor.TabIndex = 0;
            this.SourceTextEditor.Text = "";
            this.SourceTextEditor.TextChanged += new System.EventHandler(this.SourceTextEditor_TextChanged);
            // 
            // ClassPresetMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 638);
            this.Controls.Add(this.ClassFormNameTextArea);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ClassFormDeleteButton);
            this.Controls.Add(this.ClassFormSaveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl2);
            this.Name = "ClassPresetMaker";
            this.Text = "ClassPresetMaker";
            this.tabControl2.ResumeLayout(false);
            this.HeaderTab.ResumeLayout(false);
            this.SourceTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClassFormNameTextArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ClassFormDeleteButton;
        private System.Windows.Forms.Button ClassFormSaveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage HeaderTab;
        private System.Windows.Forms.RichTextBox HeaderTextEditor;
        private System.Windows.Forms.TabPage SourceTab;
        private System.Windows.Forms.RichTextBox SourceTextEditor;
    }
}