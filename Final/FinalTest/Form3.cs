using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace FinalTest
{
    public partial class Form3 : Form
    {
        private string[] data;
        private string file = "";
        private string filepath = "";
        private void request(string userid)
        {
            HttpWebRequest req3 = (HttpWebRequest)WebRequest.Create("http://1.11.170.163:8000/api/api_storage?userid=" + userid);
            HttpWebResponse res3 = (HttpWebResponse)req3.GetResponse();

            Stream respGetStream = res3.GetResponseStream();
            StreamReader readerGet = new StreamReader(respGetStream, Encoding.UTF8);

            string result = readerGet.ReadToEnd();

            data = result.Split('>');

            label1.Text = data[0] + "\'s Storage";

            for(int i = 1; i < data.Length; i++)
            {
                listBox1.Items.Add(data[i]);
            }
        }

        public Form3(string userid)
        {
            InitializeComponent();
            request(userid);
        }

        private bool DownloadRemoteImageFile(string url, string savepath)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // 파일 이름 탐색
            string filename = "";
            string dispos = response.Headers["Content-Disposition"];
            if (!String.IsNullOrEmpty(dispos))
            {
                Regex r = new Regex(@"filename\$*(?:""(?<filename>[^""]*)""|(?<filename>[^;]*))",
                    RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);
                Match m = r.Match(dispos);
                if (m.Success)
                {
                    filename = m.Groups["filename"].Value;
                    if (filename.Contains("utf-8"))
                    {
                        filename = filename.Replace("*=utf-8\'\'", "");
                        string[] temp = filename.Split('.');
                        filename = HttpUtility.UrlDecode(temp[0]) + "." + temp[1];
                    }
                    else
                    {
                        filename = filename.Replace("=\"", "").Replace("\"", "");
                    }
                }
            }

            if ((response.StatusCode == HttpStatusCode.OK ||
                response.StatusCode == HttpStatusCode.Moved ||
                response.StatusCode == HttpStatusCode.Redirect))
            {
                using (Stream inputStream = response.GetResponseStream())
                using (Stream outputStream = File.OpenWrite(savepath))
                {

                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    do
                    {
                        bytesRead = inputStream.Read(buffer, 0, buffer.Length);
                        outputStream.Write(buffer, 0, bytesRead);
                    } while (bytesRead != 0);
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        private void download(string path)
        {
            String url = "http://1.11.170.163:8000/api/api_download?userid=" + data[0] + "&file=" + file;
            if (!DownloadRemoteImageFile(url, path))
            {
                MessageBox.Show("Download Failed: " + url);
            }
            else
            {
                MessageBox.Show("Finish");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                file = listBox1.SelectedItem.ToString();
                string[] temp = file.Split('.');
                saveFileDialog1.Filter = "[*." + temp[1] + "]|*." + temp[1];

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filepath = saveFileDialog1.FileName;

                    download(filepath);
                }
            } else
            {
                MessageBox.Show("파일을 선택해주세요.");
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "모든 파일 (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;

                string[] temp = filepath.Split('\\');

                string fileN = temp[temp.Length-1];

                string url = @"http://1.11.170.163:8000/api/api_upload?userid=" + data[0];

                var formContent = new MultipartFormDataContent();

                NameValueCollection strings = new NameValueCollection();
                strings.Add("filename", fileN);
                strings.Add("descript", "");

                foreach (string key in strings.Keys)
                {
                    string inputName = key;
                    string content = strings[key];

                    formContent.Add(new StringContent(content), inputName);
                }

                NameValueCollection files = new NameValueCollection();
                files.Add("file", filepath);

                string input = "file";
                string fullPathToFile = files["file"];

                FileStream fileStream = File.OpenRead(fullPathToFile);
                var streamContent = new StreamContent(fileStream);
                var fileContent = new ByteArrayContent(streamContent.ReadAsByteArrayAsync().Result);
                formContent.Add(fileContent, input, Path.GetFileName(fullPathToFile));

                var myHttpClient = new HttpClient();
                var response = await myHttpClient.PostAsync(url, formContent);

                if(response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("업로드 성공");
                    reload();
                }
            }
        }

        private void reload()
        {
            Delay(500);
            label1.Text = "";
            listBox1.Items.Clear();
            request(data[0]);
        }

        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                file = listBox1.SelectedItem.ToString();
                HttpWebRequest req3 = (HttpWebRequest)WebRequest.Create("http://1.11.170.163:8000/api/api_delete?userid=" + data[0] + "&file=" + file);
                HttpWebResponse res3 = (HttpWebResponse)req3.GetResponse();

                Stream respGetStream = res3.GetResponseStream();
                StreamReader readerGet = new StreamReader(respGetStream, Encoding.UTF8);

                string result = readerGet.ReadToEnd();

                if(result == "success")
                {
                    MessageBox.Show("파일 삭제 완료");
                    reload();
                }
            }
            else
            {
                MessageBox.Show("파일을 선택해주세요.");
            }
        }
    }
}
