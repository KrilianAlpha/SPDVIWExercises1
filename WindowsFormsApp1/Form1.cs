using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            Result.Text = (Convert.ToInt32(Value1.Text) + Convert.ToInt32(Value2.Text)).ToString();
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            Result.Text = (Convert.ToInt32(Value1.Text) - Convert.ToInt32(Value2.Text)).ToString();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Value1.Text = 0.ToString();
            Value2.Text = 0.ToString();
            Result.Text = 0.ToString();
        }
    }
}
