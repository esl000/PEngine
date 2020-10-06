namespace ProjectManagement
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.General = new System.Windows.Forms.TabPage();
            this.ChangeProjectOutputDirectory = new System.Windows.Forms.Button();
            this.ProjectOutputDirectoryText = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.ChangeProjectSourceDirectory = new System.Windows.Forms.Button();
            this.ProjectSourceDirectoryText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChangeProjectDirectory = new System.Windows.Forms.Button();
            this.ProjectDirectoryText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.TabPage();
            this.ClassWizard = new System.Windows.Forms.TabPage();
            this.ChangeHeaderDirectory = new System.Windows.Forms.Button();
            this.HeaderFileDirectoryTextArea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MakePublicFolder = new System.Windows.Forms.Button();
            this.PrivateToggle = new System.Windows.Forms.RadioButton();
            this.PublicToggle = new System.Windows.Forms.RadioButton();
            this.SeletePresetClass = new System.Windows.Forms.Button();
            this.ParentClassNameTextArea = new System.Windows.Forms.TextBox();
            this.CreateClassAndGenerate = new System.Windows.Forms.Button();
            this.CreateClass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ClassNameTextArea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChangeTargetDirectory = new System.Windows.Forms.Button();
            this.TargetDirectoryTextArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassForm = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.HeaderTap = new System.Windows.Forms.TabPage();
            this.HeaderCodeView = new System.Windows.Forms.RichTextBox();
            this.SourceTap = new System.Windows.Forms.TabPage();
            this.SourceCodeView = new System.Windows.Forms.RichTextBox();
            this.OpenClassFormEditor = new System.Windows.Forms.Button();
            this.DeleteClassForm = new System.Windows.Forms.Button();
            this.CreateClassForm = new System.Windows.Forms.Button();
            this.ClassFormListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ModuleWizard = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ModuleTargetDirectoryTextArea = new System.Windows.Forms.TextBox();
            this.ModuleNameTextArea = new System.Windows.Forms.TextBox();
            this.ChangeModuleTargetDirectory = new System.Windows.Forms.Button();
            this.CreateAndGenerateModule = new System.Windows.Forms.Button();
            this.CreateModule = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.General.SuspendLayout();
            this.ClassWizard.SuspendLayout();
            this.ClassForm.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.HeaderTap.SuspendLayout();
            this.SourceTap.SuspendLayout();
            this.ModuleWizard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.General);
            this.tabControl1.Controls.Add(this.Settings);
            this.tabControl1.Controls.Add(this.ClassWizard);
            this.tabControl1.Controls.Add(this.ClassForm);
            this.tabControl1.Controls.Add(this.ModuleWizard);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(841, 492);
            this.tabControl1.TabIndex = 0;
            // 
            // General
            // 
            this.General.BackColor = System.Drawing.Color.WhiteSmoke;
            this.General.Controls.Add(this.ChangeProjectOutputDirectory);
            this.General.Controls.Add(this.ProjectOutputDirectoryText);
            this.General.Controls.Add(this.label8);
            this.General.Controls.Add(this.Generate);
            this.General.Controls.Add(this.ChangeProjectSourceDirectory);
            this.General.Controls.Add(this.ProjectSourceDirectoryText);
            this.General.Controls.Add(this.label3);
            this.General.Controls.Add(this.ChangeProjectDirectory);
            this.General.Controls.Add(this.ProjectDirectoryText);
            this.General.Controls.Add(this.label1);
            this.General.Location = new System.Drawing.Point(4, 22);
            this.General.Name = "General";
            this.General.Padding = new System.Windows.Forms.Padding(3);
            this.General.Size = new System.Drawing.Size(833, 466);
            this.General.TabIndex = 0;
            this.General.Text = "General";
            // 
            // ChangeProjectOutputDirectory
            // 
            this.ChangeProjectOutputDirectory.Location = new System.Drawing.Point(35, 254);
            this.ChangeProjectOutputDirectory.Name = "ChangeProjectOutputDirectory";
            this.ChangeProjectOutputDirectory.Size = new System.Drawing.Size(75, 23);
            this.ChangeProjectOutputDirectory.TabIndex = 9;
            this.ChangeProjectOutputDirectory.Text = "change";
            this.ChangeProjectOutputDirectory.UseVisualStyleBackColor = true;
            // 
            // ProjectOutputDirectoryText
            // 
            this.ProjectOutputDirectoryText.AutoSize = true;
            this.ProjectOutputDirectoryText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProjectOutputDirectoryText.Font = new System.Drawing.Font("굴림", 10F);
            this.ProjectOutputDirectoryText.Location = new System.Drawing.Point(35, 228);
            this.ProjectOutputDirectoryText.Name = "ProjectOutputDirectoryText";
            this.ProjectOutputDirectoryText.Size = new System.Drawing.Size(67, 14);
            this.ProjectOutputDirectoryText.TabIndex = 8;
            this.ProjectOutputDirectoryText.Text = "C:\\Main";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(32, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Project Output Directory:";
            // 
            // Generate
            // 
            this.Generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Generate.Location = new System.Drawing.Point(663, 402);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(162, 56);
            this.Generate.TabIndex = 6;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // ChangeProjectSourceDirectory
            // 
            this.ChangeProjectSourceDirectory.Location = new System.Drawing.Point(35, 163);
            this.ChangeProjectSourceDirectory.Name = "ChangeProjectSourceDirectory";
            this.ChangeProjectSourceDirectory.Size = new System.Drawing.Size(75, 23);
            this.ChangeProjectSourceDirectory.TabIndex = 5;
            this.ChangeProjectSourceDirectory.Text = "change";
            this.ChangeProjectSourceDirectory.UseVisualStyleBackColor = true;
            this.ChangeProjectSourceDirectory.Click += new System.EventHandler(this.ChangeProjectSourceDirectory_Click);
            // 
            // ProjectSourceDirectoryText
            // 
            this.ProjectSourceDirectoryText.AutoSize = true;
            this.ProjectSourceDirectoryText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProjectSourceDirectoryText.Font = new System.Drawing.Font("굴림", 10F);
            this.ProjectSourceDirectoryText.Location = new System.Drawing.Point(35, 137);
            this.ProjectSourceDirectoryText.Name = "ProjectSourceDirectoryText";
            this.ProjectSourceDirectoryText.Size = new System.Drawing.Size(67, 14);
            this.ProjectSourceDirectoryText.TabIndex = 4;
            this.ProjectSourceDirectoryText.Text = "C:\\Main";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(32, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Project Source Directory:";
            // 
            // ChangeProjectDirectory
            // 
            this.ChangeProjectDirectory.Location = new System.Drawing.Point(35, 74);
            this.ChangeProjectDirectory.Name = "ChangeProjectDirectory";
            this.ChangeProjectDirectory.Size = new System.Drawing.Size(75, 23);
            this.ChangeProjectDirectory.TabIndex = 2;
            this.ChangeProjectDirectory.Text = "change";
            this.ChangeProjectDirectory.UseVisualStyleBackColor = true;
            this.ChangeProjectDirectory.Click += new System.EventHandler(this.ChangeProjectDirectory_Click);
            // 
            // ProjectDirectoryText
            // 
            this.ProjectDirectoryText.AutoSize = true;
            this.ProjectDirectoryText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProjectDirectoryText.Font = new System.Drawing.Font("굴림", 10F);
            this.ProjectDirectoryText.Location = new System.Drawing.Point(35, 48);
            this.ProjectDirectoryText.Name = "ProjectDirectoryText";
            this.ProjectDirectoryText.Size = new System.Drawing.Size(67, 14);
            this.ProjectDirectoryText.TabIndex = 1;
            this.ProjectDirectoryText.Text = "C:\\Main";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Directory:";
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(833, 466);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            // 
            // ClassWizard
            // 
            this.ClassWizard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClassWizard.Controls.Add(this.ChangeHeaderDirectory);
            this.ClassWizard.Controls.Add(this.HeaderFileDirectoryTextArea);
            this.ClassWizard.Controls.Add(this.label7);
            this.ClassWizard.Controls.Add(this.MakePublicFolder);
            this.ClassWizard.Controls.Add(this.PrivateToggle);
            this.ClassWizard.Controls.Add(this.PublicToggle);
            this.ClassWizard.Controls.Add(this.SeletePresetClass);
            this.ClassWizard.Controls.Add(this.ParentClassNameTextArea);
            this.ClassWizard.Controls.Add(this.CreateClassAndGenerate);
            this.ClassWizard.Controls.Add(this.CreateClass);
            this.ClassWizard.Controls.Add(this.label5);
            this.ClassWizard.Controls.Add(this.ClassNameTextArea);
            this.ClassWizard.Controls.Add(this.label4);
            this.ClassWizard.Controls.Add(this.ChangeTargetDirectory);
            this.ClassWizard.Controls.Add(this.TargetDirectoryTextArea);
            this.ClassWizard.Controls.Add(this.label2);
            this.ClassWizard.Location = new System.Drawing.Point(4, 22);
            this.ClassWizard.Name = "ClassWizard";
            this.ClassWizard.Padding = new System.Windows.Forms.Padding(3);
            this.ClassWizard.Size = new System.Drawing.Size(833, 466);
            this.ClassWizard.TabIndex = 2;
            this.ClassWizard.Text = "ClassWizard";
            // 
            // ChangeHeaderDirectory
            // 
            this.ChangeHeaderDirectory.Location = new System.Drawing.Point(592, 125);
            this.ChangeHeaderDirectory.Name = "ChangeHeaderDirectory";
            this.ChangeHeaderDirectory.Size = new System.Drawing.Size(70, 21);
            this.ChangeHeaderDirectory.TabIndex = 17;
            this.ChangeHeaderDirectory.Text = "change";
            this.ChangeHeaderDirectory.UseVisualStyleBackColor = true;
            this.ChangeHeaderDirectory.Click += new System.EventHandler(this.ChangeHeaderDirectory_Click);
            // 
            // HeaderFileDirectoryTextArea
            // 
            this.HeaderFileDirectoryTextArea.Location = new System.Drawing.Point(45, 127);
            this.HeaderFileDirectoryTextArea.Name = "HeaderFileDirectoryTextArea";
            this.HeaderFileDirectoryTextArea.Size = new System.Drawing.Size(541, 21);
            this.HeaderFileDirectoryTextArea.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(41, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Header File Directory";
            // 
            // MakePublicFolder
            // 
            this.MakePublicFolder.Location = new System.Drawing.Point(678, 55);
            this.MakePublicFolder.Name = "MakePublicFolder";
            this.MakePublicFolder.Size = new System.Drawing.Size(135, 21);
            this.MakePublicFolder.TabIndex = 14;
            this.MakePublicFolder.Text = "make public/private";
            this.MakePublicFolder.UseVisualStyleBackColor = true;
            this.MakePublicFolder.Click += new System.EventHandler(this.MakePublicFolder_Click);
            // 
            // PrivateToggle
            // 
            this.PrivateToggle.AutoSize = true;
            this.PrivateToggle.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PrivateToggle.Location = new System.Drawing.Point(424, 197);
            this.PrivateToggle.Name = "PrivateToggle";
            this.PrivateToggle.Size = new System.Drawing.Size(70, 19);
            this.PrivateToggle.TabIndex = 13;
            this.PrivateToggle.TabStop = true;
            this.PrivateToggle.Text = "Private";
            this.PrivateToggle.UseVisualStyleBackColor = true;
            this.PrivateToggle.CheckedChanged += new System.EventHandler(this.PrivateToggle_CheckedChanged);
            // 
            // PublicToggle
            // 
            this.PublicToggle.AutoSize = true;
            this.PublicToggle.Checked = true;
            this.PublicToggle.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PublicToggle.Location = new System.Drawing.Point(353, 197);
            this.PublicToggle.Name = "PublicToggle";
            this.PublicToggle.Size = new System.Drawing.Size(65, 19);
            this.PublicToggle.TabIndex = 12;
            this.PublicToggle.TabStop = true;
            this.PublicToggle.Text = "Public";
            this.PublicToggle.UseVisualStyleBackColor = true;
            this.PublicToggle.CheckedChanged += new System.EventHandler(this.PublicToggle_CheckedChanged);
            // 
            // SeletePresetClass
            // 
            this.SeletePresetClass.Location = new System.Drawing.Point(353, 278);
            this.SeletePresetClass.Name = "SeletePresetClass";
            this.SeletePresetClass.Size = new System.Drawing.Size(183, 21);
            this.SeletePresetClass.TabIndex = 11;
            this.SeletePresetClass.Text = "choose preset parent class";
            this.SeletePresetClass.UseVisualStyleBackColor = true;
            this.SeletePresetClass.Click += new System.EventHandler(this.SeletePresetClass_Click);
            // 
            // ParentClassNameTextArea
            // 
            this.ParentClassNameTextArea.Location = new System.Drawing.Point(45, 278);
            this.ParentClassNameTextArea.Name = "ParentClassNameTextArea";
            this.ParentClassNameTextArea.Size = new System.Drawing.Size(296, 21);
            this.ParentClassNameTextArea.TabIndex = 10;
            // 
            // CreateClassAndGenerate
            // 
            this.CreateClassAndGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateClassAndGenerate.Location = new System.Drawing.Point(663, 406);
            this.CreateClassAndGenerate.Name = "CreateClassAndGenerate";
            this.CreateClassAndGenerate.Size = new System.Drawing.Size(162, 52);
            this.CreateClassAndGenerate.TabIndex = 9;
            this.CreateClassAndGenerate.Text = "Create And Generate";
            this.CreateClassAndGenerate.UseVisualStyleBackColor = true;
            this.CreateClassAndGenerate.Click += new System.EventHandler(this.CreateClassAndGenerate_Click);
            // 
            // CreateClass
            // 
            this.CreateClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateClass.Location = new System.Drawing.Point(663, 335);
            this.CreateClass.Name = "CreateClass";
            this.CreateClass.Size = new System.Drawing.Size(162, 52);
            this.CreateClass.TabIndex = 8;
            this.CreateClass.Text = "Create Class";
            this.CreateClass.UseVisualStyleBackColor = true;
            this.CreateClass.Click += new System.EventHandler(this.CreateClass_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(41, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Parent Class Name";
            // 
            // ClassNameTextArea
            // 
            this.ClassNameTextArea.Location = new System.Drawing.Point(45, 197);
            this.ClassNameTextArea.Name = "ClassNameTextArea";
            this.ClassNameTextArea.Size = new System.Drawing.Size(296, 21);
            this.ClassNameTextArea.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(41, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Header Name";
            // 
            // ChangeTargetDirectory
            // 
            this.ChangeTargetDirectory.Location = new System.Drawing.Point(592, 55);
            this.ChangeTargetDirectory.Name = "ChangeTargetDirectory";
            this.ChangeTargetDirectory.Size = new System.Drawing.Size(70, 21);
            this.ChangeTargetDirectory.TabIndex = 2;
            this.ChangeTargetDirectory.Text = "change";
            this.ChangeTargetDirectory.UseVisualStyleBackColor = true;
            this.ChangeTargetDirectory.Click += new System.EventHandler(this.ChangeTargetDirectory_Click);
            // 
            // TargetDirectoryTextArea
            // 
            this.TargetDirectoryTextArea.Location = new System.Drawing.Point(45, 57);
            this.TargetDirectoryTextArea.Name = "TargetDirectoryTextArea";
            this.TargetDirectoryTextArea.ReadOnly = true;
            this.TargetDirectoryTextArea.Size = new System.Drawing.Size(541, 21);
            this.TargetDirectoryTextArea.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(41, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Target Project Source Directory";
            // 
            // ClassForm
            // 
            this.ClassForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClassForm.Controls.Add(this.tabControl2);
            this.ClassForm.Controls.Add(this.OpenClassFormEditor);
            this.ClassForm.Controls.Add(this.DeleteClassForm);
            this.ClassForm.Controls.Add(this.CreateClassForm);
            this.ClassForm.Controls.Add(this.ClassFormListBox);
            this.ClassForm.Controls.Add(this.label6);
            this.ClassForm.Location = new System.Drawing.Point(4, 22);
            this.ClassForm.Name = "ClassForm";
            this.ClassForm.Padding = new System.Windows.Forms.Padding(3);
            this.ClassForm.Size = new System.Drawing.Size(833, 466);
            this.ClassForm.TabIndex = 3;
            this.ClassForm.Text = "ClassForm";
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.HeaderTap);
            this.tabControl2.Controls.Add(this.SourceTap);
            this.tabControl2.Location = new System.Drawing.Point(291, 56);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(536, 404);
            this.tabControl2.TabIndex = 8;
            // 
            // HeaderTap
            // 
            this.HeaderTap.Controls.Add(this.HeaderCodeView);
            this.HeaderTap.Location = new System.Drawing.Point(4, 22);
            this.HeaderTap.Name = "HeaderTap";
            this.HeaderTap.Padding = new System.Windows.Forms.Padding(3);
            this.HeaderTap.Size = new System.Drawing.Size(528, 378);
            this.HeaderTap.TabIndex = 0;
            this.HeaderTap.Text = "Header";
            this.HeaderTap.UseVisualStyleBackColor = true;
            // 
            // HeaderCodeView
            // 
            this.HeaderCodeView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderCodeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderCodeView.Location = new System.Drawing.Point(3, 3);
            this.HeaderCodeView.Name = "HeaderCodeView";
            this.HeaderCodeView.ReadOnly = true;
            this.HeaderCodeView.Size = new System.Drawing.Size(522, 372);
            this.HeaderCodeView.TabIndex = 1;
            this.HeaderCodeView.Text = "";
            // 
            // SourceTap
            // 
            this.SourceTap.Controls.Add(this.SourceCodeView);
            this.SourceTap.Location = new System.Drawing.Point(4, 22);
            this.SourceTap.Name = "SourceTap";
            this.SourceTap.Padding = new System.Windows.Forms.Padding(3);
            this.SourceTap.Size = new System.Drawing.Size(528, 378);
            this.SourceTap.TabIndex = 1;
            this.SourceTap.Text = "Source";
            this.SourceTap.UseVisualStyleBackColor = true;
            // 
            // SourceCodeView
            // 
            this.SourceCodeView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SourceCodeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceCodeView.Location = new System.Drawing.Point(3, 3);
            this.SourceCodeView.Name = "SourceCodeView";
            this.SourceCodeView.ReadOnly = true;
            this.SourceCodeView.Size = new System.Drawing.Size(522, 372);
            this.SourceCodeView.TabIndex = 4;
            this.SourceCodeView.Text = "";
            // 
            // OpenClassFormEditor
            // 
            this.OpenClassFormEditor.Location = new System.Drawing.Point(198, 127);
            this.OpenClassFormEditor.Name = "OpenClassFormEditor";
            this.OpenClassFormEditor.Size = new System.Drawing.Size(61, 20);
            this.OpenClassFormEditor.TabIndex = 7;
            this.OpenClassFormEditor.Text = "Edit";
            this.OpenClassFormEditor.UseVisualStyleBackColor = true;
            this.OpenClassFormEditor.Click += new System.EventHandler(this.OpenClassFormEditor_Click);
            // 
            // DeleteClassForm
            // 
            this.DeleteClassForm.Location = new System.Drawing.Point(198, 91);
            this.DeleteClassForm.Name = "DeleteClassForm";
            this.DeleteClassForm.Size = new System.Drawing.Size(61, 20);
            this.DeleteClassForm.TabIndex = 6;
            this.DeleteClassForm.Text = "Delete";
            this.DeleteClassForm.UseVisualStyleBackColor = true;
            this.DeleteClassForm.Click += new System.EventHandler(this.DeleteClassForm_Click);
            // 
            // CreateClassForm
            // 
            this.CreateClassForm.Location = new System.Drawing.Point(198, 56);
            this.CreateClassForm.Name = "CreateClassForm";
            this.CreateClassForm.Size = new System.Drawing.Size(61, 20);
            this.CreateClassForm.TabIndex = 5;
            this.CreateClassForm.Text = "New";
            this.CreateClassForm.UseVisualStyleBackColor = true;
            this.CreateClassForm.Click += new System.EventHandler(this.CreateClassForm_Click);
            // 
            // ClassFormListBox
            // 
            this.ClassFormListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ClassFormListBox.FormattingEnabled = true;
            this.ClassFormListBox.HorizontalScrollbar = true;
            this.ClassFormListBox.ItemHeight = 12;
            this.ClassFormListBox.Items.AddRange(new object[] {
            "a",
            "a",
            "a",
            "a",
            "a",
            "aa",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a"});
            this.ClassFormListBox.Location = new System.Drawing.Point(15, 56);
            this.ClassFormListBox.Name = "ClassFormListBox";
            this.ClassFormListBox.Size = new System.Drawing.Size(177, 400);
            this.ClassFormListBox.TabIndex = 4;
            this.ClassFormListBox.SelectedIndexChanged += new System.EventHandler(this.ClassFormListBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(11, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Class Presets";
            // 
            // ModuleWizard
            // 
            this.ModuleWizard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ModuleWizard.Controls.Add(this.CreateAndGenerateModule);
            this.ModuleWizard.Controls.Add(this.CreateModule);
            this.ModuleWizard.Controls.Add(this.ChangeModuleTargetDirectory);
            this.ModuleWizard.Controls.Add(this.ModuleNameTextArea);
            this.ModuleWizard.Controls.Add(this.ModuleTargetDirectoryTextArea);
            this.ModuleWizard.Controls.Add(this.label10);
            this.ModuleWizard.Controls.Add(this.label9);
            this.ModuleWizard.Location = new System.Drawing.Point(4, 22);
            this.ModuleWizard.Name = "ModuleWizard";
            this.ModuleWizard.Padding = new System.Windows.Forms.Padding(3);
            this.ModuleWizard.Size = new System.Drawing.Size(833, 466);
            this.ModuleWizard.TabIndex = 4;
            this.ModuleWizard.Text = "ModuleWizard";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(29, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Target Directory";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(29, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Module Name";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ModuleTargetDirectoryTextArea
            // 
            this.ModuleTargetDirectoryTextArea.Location = new System.Drawing.Point(33, 60);
            this.ModuleTargetDirectoryTextArea.Name = "ModuleTargetDirectoryTextArea";
            this.ModuleTargetDirectoryTextArea.Size = new System.Drawing.Size(492, 21);
            this.ModuleTargetDirectoryTextArea.TabIndex = 2;
            // 
            // ModuleNameTextArea
            // 
            this.ModuleNameTextArea.Location = new System.Drawing.Point(33, 147);
            this.ModuleNameTextArea.Name = "ModuleNameTextArea";
            this.ModuleNameTextArea.Size = new System.Drawing.Size(228, 21);
            this.ModuleNameTextArea.TabIndex = 3;
            // 
            // ChangeModuleTargetDirectory
            // 
            this.ChangeModuleTargetDirectory.Location = new System.Drawing.Point(554, 60);
            this.ChangeModuleTargetDirectory.Name = "ChangeModuleTargetDirectory";
            this.ChangeModuleTargetDirectory.Size = new System.Drawing.Size(81, 23);
            this.ChangeModuleTargetDirectory.TabIndex = 4;
            this.ChangeModuleTargetDirectory.Text = "choose";
            this.ChangeModuleTargetDirectory.UseVisualStyleBackColor = true;
            this.ChangeModuleTargetDirectory.Click += new System.EventHandler(this.ChangeModuleTargetDirectory_Click);
            // 
            // CreateAndGenerateModule
            // 
            this.CreateAndGenerateModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateAndGenerateModule.Location = new System.Drawing.Point(663, 404);
            this.CreateAndGenerateModule.Name = "CreateAndGenerateModule";
            this.CreateAndGenerateModule.Size = new System.Drawing.Size(162, 52);
            this.CreateAndGenerateModule.TabIndex = 11;
            this.CreateAndGenerateModule.Text = "Create And Generate";
            this.CreateAndGenerateModule.UseVisualStyleBackColor = true;
            this.CreateAndGenerateModule.Click += new System.EventHandler(this.CreateAndGenerateModule_Click);
            // 
            // CreateModule
            // 
            this.CreateModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateModule.Location = new System.Drawing.Point(663, 333);
            this.CreateModule.Name = "CreateModule";
            this.CreateModule.Size = new System.Drawing.Size(162, 52);
            this.CreateModule.TabIndex = 10;
            this.CreateModule.Text = "Create Module";
            this.CreateModule.UseVisualStyleBackColor = true;
            this.CreateModule.Click += new System.EventHandler(this.CreateModule_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 492);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ProjectManagement";
            this.tabControl1.ResumeLayout(false);
            this.General.ResumeLayout(false);
            this.General.PerformLayout();
            this.ClassWizard.ResumeLayout(false);
            this.ClassWizard.PerformLayout();
            this.ClassForm.ResumeLayout(false);
            this.ClassForm.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.HeaderTap.ResumeLayout(false);
            this.SourceTap.ResumeLayout(false);
            this.ModuleWizard.ResumeLayout(false);
            this.ModuleWizard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage General;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeProjectDirectory;
        private System.Windows.Forms.Label ProjectDirectoryText;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button ChangeProjectSourceDirectory;
        private System.Windows.Forms.Label ProjectSourceDirectoryText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage ClassWizard;
        private System.Windows.Forms.Button CreateClassAndGenerate;
        private System.Windows.Forms.Button CreateClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ClassNameTextArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ChangeTargetDirectory;
        private System.Windows.Forms.TextBox TargetDirectoryTextArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage ClassForm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ChangeProjectOutputDirectory;
        private System.Windows.Forms.Label ProjectOutputDirectoryText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SeletePresetClass;
        private System.Windows.Forms.TextBox ParentClassNameTextArea;
        private System.Windows.Forms.ListBox ClassFormListBox;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage HeaderTap;
        private System.Windows.Forms.RichTextBox HeaderCodeView;
        private System.Windows.Forms.TabPage SourceTap;
        private System.Windows.Forms.RichTextBox SourceCodeView;
        private System.Windows.Forms.Button OpenClassFormEditor;
        private System.Windows.Forms.Button DeleteClassForm;
        private System.Windows.Forms.Button CreateClassForm;
        private System.Windows.Forms.RadioButton PrivateToggle;
        private System.Windows.Forms.RadioButton PublicToggle;
        private System.Windows.Forms.Button ChangeHeaderDirectory;
        private System.Windows.Forms.TextBox HeaderFileDirectoryTextArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button MakePublicFolder;
        private System.Windows.Forms.TabPage ModuleWizard;
        private System.Windows.Forms.TextBox ModuleTargetDirectoryTextArea;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ChangeModuleTargetDirectory;
        private System.Windows.Forms.TextBox ModuleNameTextArea;
        private System.Windows.Forms.Button CreateAndGenerateModule;
        private System.Windows.Forms.Button CreateModule;
    }
}

