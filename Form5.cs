using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 Form = new Form6();
            Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 Form = new Form7();
            Form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 Form = new Form8();
            Form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 Form = new Form9();
            Form.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 Form = new Form10();
            Form.ShowDialog();
        }
    }
}
