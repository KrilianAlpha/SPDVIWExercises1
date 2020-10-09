namespace SPDVIWExercises1_Exercice1
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
            this.LabelExercise1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelExercise1
            // 
            this.LabelExercise1.AutoSize = true;
            this.LabelExercise1.Location = new System.Drawing.Point(201, 120);
            this.LabelExercise1.Name = "LabelExercise1";
            this.LabelExercise1.Size = new System.Drawing.Size(75, 13);
            this.LabelExercise1.TabIndex = 0;
            this.LabelExercise1.Text = "Click The form";
            this.LabelExercise1.Click += new System.EventHandler(this.LabelExecise1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 255);
            this.Controls.Add(this.LabelExercise1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelExercise1;
    }
}

