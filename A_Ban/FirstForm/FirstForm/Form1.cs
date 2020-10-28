using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstForm
{
    public partial class Form1 : Form
    {
        private DateTime dTime;
        public Form1()
        {
            InitializeComponent();

            dTime = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetDTime().ToString());
        }

        private DateTime GetDTime()
        {
            dTime = DateTime.Now;
            return dTime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("로드 중...");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("종료...");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("정말 닫을 까요?", "닫기",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
