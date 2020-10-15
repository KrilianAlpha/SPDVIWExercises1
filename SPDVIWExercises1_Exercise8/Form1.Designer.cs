namespace SPDVIWExercises1_Exercise8
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
            this.List = new System.Windows.Forms.ListBox();
            this.Class1Button = new System.Windows.Forms.Button();
            this.Class2Button = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // List
            // 
            this.List.FormattingEnabled = true;
            this.List.Location = new System.Drawing.Point(12, 12);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(156, 95);
            this.List.TabIndex = 0;
            this.List.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // Class1Button
            // 
            this.Class1Button.Location = new System.Drawing.Point(12, 141);
            this.Class1Button.Name = "Class1Button";
            this.Class1Button.Size = new System.Drawing.Size(75, 23);
            this.Class1Button.TabIndex = 1;
            this.Class1Button.Text = "Classroom 1";
            this.Class1Button.UseVisualStyleBackColor = true;
            this.Class1Button.Click += new System.EventHandler(this.Class1Button_Click);
            // 
            // Class2Button
            // 
            this.Class2Button.Location = new System.Drawing.Point(93, 141);
            this.Class2Button.Name = "Class2Button";
            this.Class2Button.Size = new System.Drawing.Size(75, 23);
            this.Class2Button.TabIndex = 2;
            this.Class2Button.Text = "Classroom 2";
            this.Class2Button.UseVisualStyleBackColor = true;
            this.Class2Button.Click += new System.EventHandler(this.Class2Button_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 170);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(156, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear List";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(12, 115);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(156, 20);
            this.Result.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 209);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.Class2Button);
            this.Controls.Add(this.Class1Button);
            this.Controls.Add(this.List);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Button Class1Button;
        private System.Windows.Forms.Button Class2Button;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox Result;
    }
}

