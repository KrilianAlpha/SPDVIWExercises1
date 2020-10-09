using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDVIWExercises1_Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxExercise2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxExercise2.Checked)
            {
                MessageBox.Show("Checked");
            } else
            {
                MessageBox.Show("Unchecked");
            }
        }
    }
}
