namespace Lab_4
{
    partial class FormNewCompetition
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
            this.saveButton = new System.Windows.Forms.Button();
            this.speechCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.newSpeechButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(61, 413);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(102, 43);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // speechCheckedListBox
            // 
            this.speechCheckedListBox.FormattingEnabled = true;
            this.speechCheckedListBox.Location = new System.Drawing.Point(61, 187);
            this.speechCheckedListBox.Name = "speechCheckedListBox";
            this.speechCheckedListBox.Size = new System.Drawing.Size(321, 174);
            this.speechCheckedListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(177, 83);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(205, 22);
            this.nameTextBox.TabIndex = 3;
            // 
            // newSpeechButton
            // 
            this.newSpeechButton.Location = new System.Drawing.Point(273, 413);
            this.newSpeechButton.Name = "newSpeechButton";
            this.newSpeechButton.Size = new System.Drawing.Size(108, 43);
            this.newSpeechButton.TabIndex = 4;
            this.newSpeechButton.Text = "new speech";
            this.newSpeechButton.UseVisualStyleBackColor = true;
            this.newSpeechButton.Click += new System.EventHandler(this.newSpeechButton_Click);
            // 
            // FormNewCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 550);
            this.Controls.Add(this.newSpeechButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speechCheckedListBox);
            this.Controls.Add(this.saveButton);
            this.Name = "FormNewCompetition";
            this.Text = "FormNewCompetition";
            this.Activated += new System.EventHandler(this.FormNewCompetition_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckedListBox speechCheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button newSpeechButton;
    }
}