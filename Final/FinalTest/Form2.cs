using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTest
{
    public partial class Form2 : Form
    {
        private bool idcheck = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://1.11.170.163:8000/api/api_idcheck?userid=" + textBox1.Text);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            Stream respGetStream = res.GetResponseStream();
            StreamReader readerGet = new StreamReader(respGetStream, Encoding.UTF8);

            string result = readerGet.ReadToEnd();

            if (result == "success")
            {
                MessageBox.Show("사용 가능 아이디입니다.");
                idcheck = true;
                textBox2.Focus();
            }
            else
            {
                MessageBox.Show("사용 불가능한 아이디입니다.");
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!idcheck)
            {
                MessageBox.Show("ID Check를 해주세요.");
                button1.Focus();
            } else if(textBox2.Text == "")
            {
                MessageBox.Show("PW를 입력해주세요.");
                textBox2.Focus();
            } else if(textBox3.Text == "")
            {
                MessageBox.Show("PW Again을 입력해주세요.");
                textBox3.Focus();
            } else if(textBox4.Text == "")
            {
                MessageBox.Show("이름를 입력해주세요.");
                textBox4.Focus();
            } else if (textBox5.Text == "")
            {
                MessageBox.Show("전화번호를 입력해주세요.");
                textBox5.Focus();
            } else if(textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("비밀번호가 같지 않습니다.\n다시 입력해주세요.");
                textBox3.Focus();
            } else
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://1.11.170.163:8000/api/api_signin?userid="
                    + textBox1.Text + "&userpw=" + textBox2.Text + "&username=" + textBox4.Text + "&userphone=" + textBox5.Text);
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();

                Stream respGetStream = res.GetResponseStream();
                StreamReader readerGet = new StreamReader(respGetStream, Encoding.UTF8);

                string result = readerGet.ReadToEnd();

                if (result == "success")
                {
                    MessageBox.Show("회원가입 성공!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("회원가입 실패...");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    idcheck = false;
                    textBox1.Focus();
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            idcheck = false;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            } else if(textBox5.Text.Length == 13)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            if(textBox5.Text.Length == 3 || textBox5.Text.Length == 8)
            {
                textBox5.Text += "-";
                textBox5.SelectionStart = textBox5.Text.Length;
            }
        }
    }
}
