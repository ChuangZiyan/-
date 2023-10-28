using Jint;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace 同步器
{
    public partial class 腳本窗體 : Form
    {
        public 腳本窗體()
        {
            InitializeComponent();
        }

        public void 點擊坐標(int x, int y)
        {
            if (控制窗體.self.控制端大漠 != null)
            {
                控制窗體.self.控制端大漠.MoveTo(x, y);
                控制窗體.self.控制端大漠.delay(50);
                控制窗體.self.控制端大漠.LeftClick();
            }


            foreach (var 大漠 in 控制窗體.self.大漠集合)
            {
                大漠.MoveTo(x, y);
                大漠.delay(50);
                大漠.LeftClick();
            }
        }

        public void 輸入文本(string 文本)
        {
            if (控制窗體.self.控制端大漠 != null)
            {
                控制窗體.self.控制端大漠.SetWindowState(控制窗體.self.控制端大漠.GetBindWindow(), 1);
                控制窗體.self.控制端大漠.SendString(控制窗體.self.控制端大漠.GetBindWindow(), 文本);
            }

            foreach (var 大漠 in 控制窗體.self.大漠集合)
            {
                大漠.SetWindowState(大漠.GetBindWindow(), 1);
                大漠.SendString(大漠.GetBindWindow(), 文本);
            }
        }

        public void 等待延遲(int 毫秒)
        {
            Thread.Sleep(毫秒);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var engine = new Engine();
            engine.SetValue("tap", new Action<int, int>(點擊坐標));
            engine.SetValue("input", new Action<string>(輸入文本));
            engine.SetValue("sleep", new Action<int>(等待延遲));

            engine.SetValue("點擊坐標", new Action<int, int>(點擊坐標));
            engine.SetValue("輸入文本", new Action<string>(輸入文本));
            engine.SetValue("等待延遲", new Action<int>(等待延遲));
            engine.Execute(richTextBox1.Text);
        }

        private void 打開_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "打開";
            openFile.Filter = "腳本文件|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFile.FileName);
            }
        }

        private void 儲存_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "儲存";
            sfd.Filter = "腳本文件|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, richTextBox1.Text);
            }
        }

        private void 坐標_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor.Current = Cursors.Hand;
            }
        }

        private void 坐標_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Default;
            richTextBox1.AppendText("x:" + Control.MousePosition.X.ToString());
            Point formPoint = this.PointToClient(Control.MousePosition);
            this.Text = Control.MousePosition.X.ToString() + " " + Control.MousePosition.Y.ToString();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tap 點擊坐標\ninput 輸入文本\nsleep 等待延遲");
        }
    }
}
