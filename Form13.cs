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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 Form = new Form14();
            Form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form15 Form = new Form15();
            Form.ShowDialog();
        }
    }
}
