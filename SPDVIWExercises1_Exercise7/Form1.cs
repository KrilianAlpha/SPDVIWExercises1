﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDVIWExercises1_Exercise7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Result.Text = "The choosen color is: " + OptList.SelectedItem.ToString();
        }
    }
}
