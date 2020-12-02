using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerEx
{
    public partial class Form1 : Form
    {
        private int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (index == 8)
            //{
            //    index = 0;
            //}

            index %= imageList1.Images.Count;
            label1.Image = imageList1.Images[index++];
        }
    }
}
