using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Flat.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Popup.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox1.Text, checkBox1.Checked);

        }

        private void UpdateLabel(string text, bool check)
        {

            if (check)
            {
                label2.Text = label2.Text + text;
            } else
            {
                string temp = label2.Text;
                int i = temp.IndexOf(text);
                label2.Text = temp.Remove(i, text.Length);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox2.Text, checkBox2.Checked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox3.Text, checkBox3.Checked);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox4.Text, checkBox4.Checked);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = radioButton2.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }

        private void linkLabel2_LinkClicked(object senders, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("Notepad.exe", linkLabel2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "ID : " + textBox1.Text + "\r\n" + "PW : " + textBox2.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(textBox4.Text != "")
            {
                listBox1.Items.Add(textBox4.Text);
                textBox4.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex > -1) 
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("더이상 삭제할 수 없습니다.");
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                listBox1.Items.Add(comboBox1.SelectedItem);
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                comboBox1.Items.Add(listBox1.Text);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string temp = "";
            foreach(string str in checkedListBox1.CheckedItems)
            {
                temp += str + " ";
            }
            MessageBox.Show("선택 : " + temp);
        }
    }
}
