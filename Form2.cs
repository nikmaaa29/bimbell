﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nikmaaa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 Form = new Form5();
            Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 Form = new Form11();
            Form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 Form = new Form12();
            Form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 Form = new Form13();
            Form.ShowDialog();
        }
    }
}
