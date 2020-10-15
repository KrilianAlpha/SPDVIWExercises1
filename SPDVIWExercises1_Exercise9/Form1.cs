using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDVIWExercises1_Exercise9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Result.Text = OptList.SelectedItem.ToString();
        }

        private void EvenButton_Click(object sender, EventArgs e)
        {
            string[] value = {"Nº0", "Nº2", "Nº4", "Nº6", "Nº8", "Nº10"};
            OptList.Items.AddRange(value);
        }

        private void OddButton_Click(object sender, EventArgs e)
        {
            string[] value = { "Nº1", "Nº3", "Nº5", "Nº7", "Nº9" };
            OptList.Items.AddRange(value);
        }
    }
}
