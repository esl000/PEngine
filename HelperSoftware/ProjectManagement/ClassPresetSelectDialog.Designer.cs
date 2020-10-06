namespace ProjectManagement
{
    partial class ClassPresetSelectDialog
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
            this.ClassPresetListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelWorkingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClassPresetListBox
            // 
            this.ClassPresetListBox.FormattingEnabled = true;
            this.ClassPresetListBox.ItemHeight = 12;
            this.ClassPresetListBox.Location = new System.Drawing.Point(13, 49);
            this.ClassPresetListBox.Name = "ClassPresetListBox";
            this.ClassPresetListBox.Size = new System.Drawing.Size(264, 328);
            this.ClassPresetListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(52, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Class Preset";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(13, 384);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(123, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelWorkingButton
            // 
            this.CancelWorkingButton.Location = new System.Drawing.Point(153, 384);
            this.CancelWorkingButton.Name = "CancelWorkingButton";
            this.CancelWorkingButton.Size = new System.Drawing.Size(123, 23);
            this.CancelWorkingButton.TabIndex = 3;
            this.CancelWorkingButton.Text = "Cancel";
            this.CancelWorkingButton.UseVisualStyleBackColor = true;
            this.CancelWorkingButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ClassPresetSelectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 411);
            this.Controls.Add(this.CancelWorkingButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassPresetListBox);
            this.Name = "ClassPresetSelectDialog";
            this.Text = "ClassPresetSelectDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ClassPresetListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelWorkingButton;
    }
}