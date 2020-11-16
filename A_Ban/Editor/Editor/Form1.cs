using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filepath = "";
        string copyfield = "";

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;

                StreamReader sr = new StreamReader(filepath);

                string result = sr.ReadToEnd();

                textBox1.Text = result;
                sr.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "텍스트 파일 (*.txt)|*.txt";

            if (textBox1.Text.Equals("") != true)
            {
                if (filepath.Equals("") == true)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        filepath = saveFileDialog1.FileName;

                        SaveFile();
                    }
                }
                else
                {
                    SaveFile();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = saveFileDialog1.FileName;

                SaveFile();
            }
        }

        private void SaveFile()
        {
            StreamWriter sw;
            sw = File.CreateText(filepath);

            sw.WriteLine(textBox1.Text);
            sw.Close();

            textBox1.Text = "";

            filepath = "";

            Form2 f = new Form2();

            f.Show();

            textBox1.Font = DefaultFont;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            copyfield = textBox1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "\r\n" + copyfield;
        }
    }
}
