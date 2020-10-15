namespace SPDVIWExercises1_Exercise7
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
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OptList
            // 
            this.OptList.FormattingEnabled = true;
            this.OptList.Items.AddRange(new object[] {
            "White",
            "Purple",
            "Indigo",
            "Red",
            "Black"});
            this.OptList.Location = new System.Drawing.Point(43, 50);
            this.OptList.Name = "OptList";
            this.OptList.Size = new System.Drawing.Size(121, 21);
            this.OptList.TabIndex = 0;
            this.OptList.SelectedIndexChanged += new System.EventHandler(this.OptList_SelectedIndexChanged);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(43, 132);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(314, 20);
            this.Result.TabIndex = 1;
            this.Result.Text = "Nothing Selected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 177);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.OptList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OptList;
        private System.Windows.Forms.TextBox Result;
    }
}

