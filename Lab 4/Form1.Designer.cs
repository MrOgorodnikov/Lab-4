namespace Lab_4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.competitionsTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.newCompetitionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // competitionsTextBox
            // 
            this.competitionsTextBox.Location = new System.Drawing.Point(58, 82);
            this.competitionsTextBox.Multiline = true;
            this.competitionsTextBox.Name = "competitionsTextBox";
            this.competitionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.competitionsTextBox.Size = new System.Drawing.Size(365, 363);
            this.competitionsTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(58, 495);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // newCompetitionButton
            // 
            this.newCompetitionButton.Location = new System.Drawing.Point(473, 82);
            this.newCompetitionButton.Name = "newCompetitionButton";
            this.newCompetitionButton.Size = new System.Drawing.Size(141, 40);
            this.newCompetitionButton.TabIndex = 2;
            this.newCompetitionButton.Text = "new competition";
            this.newCompetitionButton.UseVisualStyleBackColor = true;
            this.newCompetitionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 548);
            this.Controls.Add(this.newCompetitionButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.competitionsTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox competitionsTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button newCompetitionButton;
    }
}

