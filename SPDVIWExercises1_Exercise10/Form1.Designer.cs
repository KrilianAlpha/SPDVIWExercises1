namespace SPDVIWExercises1_Exercise10
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
            this.Scroll = new System.Windows.Forms.HScrollBar();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Scroll
            // 
            this.Scroll.Location = new System.Drawing.Point(9, 9);
            this.Scroll.Maximum = 89;
            this.Scroll.Minimum = 50;
            this.Scroll.Name = "Scroll";
            this.Scroll.Size = new System.Drawing.Size(416, 17);
            this.Scroll.TabIndex = 0;
            this.Scroll.Value = 50;
            this.Scroll.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(9, 44);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(413, 20);
            this.Result.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 83);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Scroll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar Scroll;
        private System.Windows.Forms.TextBox Result;
    }
}

