using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpDownEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(domainUpDown1.SelectedItem.ToString());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown1.Value;
            label1.Text = d + " * " + d + " * " + d + " = ";
            textBox1.Text = Math.Pow((double)d, 3).ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown2.Value = trackBar1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)numericUpDown2.Value;
        }
    }
}
