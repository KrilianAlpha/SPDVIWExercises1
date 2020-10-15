namespace SPDVIWExercises1_Exercise9
{
    partial class Form1
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
            this.OptList = new System.Windows.Forms.ComboBox();
            this.OddButton = new System.Windows.Forms.Button();
            this.EvenButton = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OptList
            // 
            this.OptList.FormattingEnabled = true;
            this.OptList.Location = new System.Drawing.Point(12, 12);
            this.OptList.Name = "OptList";
            this.OptList.Size = new System.Drawing.Size(156, 21);
            this.OptList.Sorted = true;
            this.OptList.TabIndex = 0;
            this.OptList.SelectedIndexChanged += new System.EventHandler(this.OptList_SelectedIndexChanged);
            // 
            // OddButton
            // 
            this.OddButton.Location = new System.Drawing.Point(93, 39);
            this.OddButton.Name = "OddButton";
            this.OddButton.Size = new System.Drawing.Size(75, 23);
            this.OddButton.TabIndex = 1;
            this.OddButton.Text = "Odd";
            this.OddButton.UseVisualStyleBackColor = true;
            this.OddButton.Click += new System.EventHandler(this.OddButton_Click);
            // 
            // EvenButton
            // 
            this.EvenButton.Location = new System.Drawing.Point(12, 39);
            this.EvenButton.Name = "EvenButton";
            this.EvenButton.Size = new System.Drawing.Size(75, 23);
            this.EvenButton.TabIndex = 2;
            this.EvenButton.Text = "Even";
            this.EvenButton.UseVisualStyleBackColor = true;
            this.EvenButton.Click += new System.EventHandler(this.EvenButton_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(12, 68);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(156, 20);
            this.Result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 101);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.EvenButton);
            this.Controls.Add(this.OddButton);
            this.Controls.Add(this.OptList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OptList;
        private System.Windows.Forms.Button OddButton;
        private System.Windows.Forms.Button EvenButton;
        private System.Windows.Forms.TextBox Result;
    }
}

