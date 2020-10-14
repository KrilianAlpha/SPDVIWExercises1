namespace WindowsFormsApp1
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
            this.Value1 = new System.Windows.Forms.TextBox();
            this.Value2 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Options = new System.Windows.Forms.ListBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Value1
            // 
            this.Value1.Location = new System.Drawing.Point(101, 87);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(100, 20);
            this.Value1.TabIndex = 0;
            this.Value1.Text = "0";
            // 
            // Value2
            // 
            this.Value2.Location = new System.Drawing.Point(101, 133);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(100, 20);
            this.Value2.TabIndex = 1;
            this.Value2.Text = "0";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(370, 110);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 20);
            this.Result.TabIndex = 2;
            this.Result.Text = "0";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(248, 176);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select a Operation";
            // 
            // Options
            // 
            this.Options.FormattingEnabled = true;
            this.Options.Items.AddRange(new object[] {
            "+",
            "-"});
            this.Options.Location = new System.Drawing.Point(248, 110);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(75, 30);
            this.Options.TabIndex = 7;
            this.Options.SelectedIndexChanged += new System.EventHandler(this.Options_SelectedIndexChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(101, 176);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 259);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Value2);
            this.Controls.Add(this.Value1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Value1;
        private System.Windows.Forms.TextBox Value2;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Options;
        private System.Windows.Forms.Button CalculateButton;
    }
}

