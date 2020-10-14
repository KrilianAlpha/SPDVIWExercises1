using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDVIWExercises1_Exercise5
{
    public partial class Form1 : Form
    {
        private string v1 = "";
        private string v2 = "";
        private string v3 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (Option1.Checked == true) { v1 = Option1.Text; }
            if (Option2.Checked == true) { v2 = Option2.Text; }
            if (Option3.Checked == true) { v3 = Option3.Text; }
            Result.Text = "Selected: " + v1 + " " + v2 + " " + v3;
            v1 = ""; 
            v2= "";
            v3 = "";
        }
    }
}
