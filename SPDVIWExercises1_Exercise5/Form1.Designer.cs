namespace SPDVIWExercises1_Exercise5
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
            this.Option1 = new System.Windows.Forms.CheckBox();
            this.Option2 = new System.Windows.Forms.CheckBox();
            this.Option3 = new System.Windows.Forms.CheckBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Option1
            // 
            this.Option1.AutoSize = true;
            this.Option1.Location = new System.Drawing.Point(12, 12);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(46, 17);
            this.Option1.TabIndex = 0;
            this.Option1.Text = "Dog";
            this.Option1.UseVisualStyleBackColor = true;
            // 
            // Option2
            // 
            this.Option2.AutoSize = true;
            this.Option2.Location = new System.Drawing.Point(12, 50);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(45, 17);
            this.Option2.TabIndex = 1;
            this.Option2.Text = "Fish";
            this.Option2.UseVisualStyleBackColor = true;
            // 
            // Option3
            // 
            this.Option3.AutoSize = true;
            this.Option3.Location = new System.Drawing.Point(12, 89);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(42, 17);
            this.Option3.TabIndex = 2;
            this.Option3.Text = "Cat";
            this.Option3.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(12, 126);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // Result
            // 
            this.Result.Enabled = false;
            this.Result.Location = new System.Drawing.Point(118, 128);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(462, 20);
            this.Result.TabIndex = 4;
            this.Result.Text = "Nothing Selected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 170);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.Option3);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Option1;
        private System.Windows.Forms.CheckBox Option2;
        private System.Windows.Forms.CheckBox Option3;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox Result;
    }
}

