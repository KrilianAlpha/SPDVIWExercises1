using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDVIWExercises1_Exercise8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Result.Text = List.SelectedItem.ToString();
        }

        private void Class1Button_Click(object sender, EventArgs e)
        {
            List.Items.Clear();
            string[] students = {"Jose Ramon", "Maria Angel", "Alberto Romero"};
            for(int i = 0; i < students.Length; i++)
            {
                List.Items.Add(students[i]);
            }
        }

        private void Class2Button_Click(object sender, EventArgs e)
        {
            List.Items.Clear();
            string[] students = { "Joan Montserrat", "Toni Prats", "Mauro Montero" };
            for (int i = 0; i < students.Length; i++)
            {
                List.Items.Add(students[i]);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            List.Items.Clear();
        }
    }
}
