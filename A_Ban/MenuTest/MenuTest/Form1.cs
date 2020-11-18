using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuTest
{
    public partial class Form1 : Form
    {
        private int num = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 새파일NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 지우기EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void 새파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 지우기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            Point mp = PointToClient(MousePosition);
            //MessageBox.Show(mp.X + ", " + mp.Y);
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateLabel("MouseDown", e.X, e.Y, e);
        }

        private void UpdateLabel(string v, int x, int y, MouseEventArgs e)
        {
            string msg = string.Format("{0} X : {1}, Y : {2}", v, x, y);
            string tmsg = DateTime.Now.ToShortTimeString();
            tmsg += " " + msg;
            listBox1.Items.Insert(0, tmsg);
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UpdateLabel("DoubleClick", e.X, e.Y, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseWheel += new MouseEventHandler(Form1_MouseWheel);
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            textBox1.Text = (e.Delta > 0 ? num++ : num--).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = 0;
            textBox1.Text = num.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.Control;
            button3.Focus();
            if (button3.Focused)
            {
                button3.BackColor = SystemColors.ControlDark;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = SystemColors.Control;
            button2.Focus();
            if (button2.Focused)
            {
                button2.BackColor = SystemColors.ControlDark;
            }
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            int px = button4.Location.X;
            int py = button4.Location.Y;

            switch (e.KeyCode)
            {
                case Keys.A:
                    px -= 10;
                    break;
                case Keys.D:
                    px += 10;
                    break;
                case Keys.W:
                    py -= 10;
                    break;
                case Keys.S:
                    py += 10;
                    break;
            }

            button4.Text = e.KeyCode.ToString();
            button4.Location = new Point(px, py);
        }
    }
}
