using CliWrap;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace 同步器.窗體
{
    public partial class 批量啟動 : Form
    {
        public 批量啟動()
        {
            InitializeComponent();
        }

        private void 啟動瀏覽器(string 類型, string 檔案, string url)
        {
            var 命令行 = $"start {類型} --user-data-dir={檔案} {url}";
            Cli.Wrap("cmd.exe").WithArguments(new[] { "/c", 命令行 }).ExecuteAsync();
        }

        private void 啟動_Click(object sender, EventArgs e)
        {
            foreach (var line in richTextBox1.Lines)
            {
                var 類型 = line.ToLower().Split('|')[0];
                var 檔案 = line.ToLower().Split('|')[1];
                var 主頁 = line.ToLower().Split('|')[2];
                啟動瀏覽器(類型, 檔案, 主頁);
                Thread.Sleep(1000);
            }
        }


        private void 儲存_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "儲存";
            sfd.Filter = "啟動文件|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, richTextBox1.Text);
            }
        }
    }
}
