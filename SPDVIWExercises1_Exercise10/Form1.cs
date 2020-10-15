using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDVIWExercises1_Exercise10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Scroll_ValueChanged(object sender, EventArgs e)
        {
            Result.Text = "%" + Scroll.Value.ToString();
        }
    }
}
