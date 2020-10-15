namespace SPDVIWExercises1_Exercise6
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
            this.OkButton = new System.Windows.Forms.Button();
            this.RadioPanel = new System.Windows.Forms.Panel();
            this.Option1 = new System.Windows.Forms.RadioButton();
            this.Option2 = new System.Windows.Forms.RadioButton();
            this.Option3 = new System.Windows.Forms.RadioButton();
            this.Result = new System.Windows.Forms.TextBox();
            this.RadioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(12, 96);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // RadioPanel
            // 
            this.RadioPanel.Controls.Add(this.Option3);
            this.RadioPanel.Controls.Add(this.Option2);
            this.RadioPanel.Controls.Add(this.Option1);
            this.RadioPanel.Location = new System.Drawing.Point(67, 22);
            this.RadioPanel.Name = "RadioPanel";
            this.RadioPanel.Size = new System.Drawing.Size(92, 68);
            this.RadioPanel.TabIndex = 1;
            // 
            // Option1
            // 
            this.Option1.AutoSize = true;
            this.Option1.Location = new System.Drawing.Point(3, 3);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(55, 17);
            this.Option1.TabIndex = 0;
            this.Option1.TabStop = true;
            this.Option1.Text = "Purple";
            this.Option1.UseVisualStyleBackColor = true;
            // 
            // Option2
            // 
            this.Option2.AutoSize = true;
            this.Option2.Location = new System.Drawing.Point(3, 26);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(52, 17);
            this.Option2.TabIndex = 1;
            this.Option2.TabStop = true;
            this.Option2.Text = "Black";
            this.Option2.UseVisualStyleBackColor = true;
            // 
            // Option3
            // 
            this.Option3.AutoSize = true;
            this.Option3.Location = new System.Drawing.Point(3, 49);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(53, 17);
            this.Option3.TabIndex = 2;
            this.Option3.TabStop = true;
            this.Option3.Text = "White";
            this.Option3.UseVisualStyleBackColor = true;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(12, 125);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(250, 20);
            this.Result.TabIndex = 2;
            this.Result.Text = "Nothing Selected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 160);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.RadioPanel);
            this.Controls.Add(this.OkButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.RadioPanel.ResumeLayout(false);
            this.RadioPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Panel RadioPanel;
        private System.Windows.Forms.RadioButton Option3;
        private System.Windows.Forms.RadioButton Option2;
        private System.Windows.Forms.RadioButton Option1;
        private System.Windows.Forms.TextBox Result;
    }
}

