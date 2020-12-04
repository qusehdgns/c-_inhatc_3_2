using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://1.11.170.163:8000/api/api_login?userid=" + textBox1.Text + "&userpw=" + textBox2.Text);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            Stream respGetStream = res.GetResponseStream();
            StreamReader readerGet = new StreamReader(respGetStream, Encoding.UTF8);

            string result = readerGet.ReadToEnd();

            if(result == "success")
            {
                Form3 form3 = new Form3(textBox1.Text);
                form3.FormClosed += new FormClosedEventHandler(form3_FormClosed);
                form3.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("ID와 PW를 확인해주세요.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
