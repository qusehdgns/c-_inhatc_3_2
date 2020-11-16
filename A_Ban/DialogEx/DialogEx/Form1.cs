using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Temp";
            openFileDialog1.Filter = "모든 파일(*.*)|*.*|텍스트 파일(*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();
            foreach(string fn in openFileDialog1.FileNames)
            {
                textBox1.Text += fn + "\r\n";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
            textBox1.ForeColor = fontDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button3.BackColor = colorDialog1.Color;
            BackColor = colorDialog1.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrinterSettings printer = new PrinterSettings();
            printDialog1.PrinterSettings = printer;

            PrintDocument pd = new PrintDocument();
            printDialog1.Document = pd;

            printDialog1.ShowDialog();
        }
    }
}
