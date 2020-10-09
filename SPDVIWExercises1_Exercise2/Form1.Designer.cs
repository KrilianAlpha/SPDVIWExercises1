namespace SPDVIWExercises1_Exercise2
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
            this.checkBoxExercise2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxExercise2
            // 
            this.checkBoxExercise2.AutoSize = true;
            this.checkBoxExercise2.Location = new System.Drawing.Point(424, 60);
            this.checkBoxExercise2.Name = "checkBoxExercise2";
            this.checkBoxExercise2.Size = new System.Drawing.Size(74, 17);
            this.checkBoxExercise2.TabIndex = 0;
            this.checkBoxExercise2.Text = "checkBox";
            this.checkBoxExercise2.UseVisualStyleBackColor = true;
            this.checkBoxExercise2.CheckedChanged += new System.EventHandler(this.checkBoxExercise2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 131);
            this.Controls.Add(this.checkBoxExercise2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxExercise2;
    }
}