namespace Lab_4
{
    partial class FormNewSpeech
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
            this.newMemberButton = new System.Windows.Forms.Button();
            this.membersCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(98, 436);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newMemberButton
            // 
            this.newMemberButton.Location = new System.Drawing.Point(359, 435);
            this.newMemberButton.Name = "newMemberButton";
            this.newMemberButton.Size = new System.Drawing.Size(75, 23);
            this.newMemberButton.TabIndex = 1;
            this.newMemberButton.Text = "New";
            this.newMemberButton.UseVisualStyleBackColor = true;
            this.newMemberButton.Click += new System.EventHandler(this.newMemberButton_Click);
            // 
            // membersCheckedListBox
            // 
            this.membersCheckedListBox.FormattingEnabled = true;
            this.membersCheckedListBox.Location = new System.Drawing.Point(98, 81);
            this.membersCheckedListBox.Name = "membersCheckedListBox";
            this.membersCheckedListBox.Size = new System.Drawing.Size(336, 327);
            this.membersCheckedListBox.TabIndex = 2;
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Location = new System.Drawing.Point(146, 48);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(100, 22);
            this.scoreTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(285, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "individual";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormNewSpeech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 579);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.membersCheckedListBox);
            this.Controls.Add(this.newMemberButton);
            this.Controls.Add(this.saveButton);
            this.Name = "FormNewSpeech";
            this.Text = "FormNewSpeech";
            this.Activated += new System.EventHandler(this.FormNewSpeech_Activated);
            this.Load += new System.EventHandler(this.FormNewSpeech_Load);
            this.EnabledChanged += new System.EventHandler(this.FormNewSpeech_EnabledChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newMemberButton;
        private System.Windows.Forms.CheckedListBox membersCheckedListBox;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}