﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDVIWExercises1_Exercise6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rb in RadioPanel.Controls)
            {
                if(rb.Checked == true)
                {
                    Result.Text = rb.Text;
                }
            }
        }
    }
}
