﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calc;

namespace Session_07
{
    public partial class StudentsForm : Form
    {
        public List<StudentInfo> Students { get; set; }
        private StudentInfo _studentsInfo;

        public StudentsForm()
        {
            InitializeComponent();
        }

        private void Students_Click(object sender, EventArgs e)
        {

        }

        private void Students_new_Click(object sender, EventArgs e)
        {

        }

        private void Students_del_Click(object sender, EventArgs e)
        {

        }

        private void Students_save_Click(object sender, EventArgs e)
        {

        }

        private void Students_exits_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //Not closing window.
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
