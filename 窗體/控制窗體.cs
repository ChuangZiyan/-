using CliWrap;
using Gma.System.MouseKeyHook;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 同步器.窗體;
using static 同步器.公共函數;

namespace 同步器
{
    public partial class 控制窗體 : Form
    {
        public static 控制窗體 self;
        public int 控制端句柄;
        public dmsoft 控制端大漠;
        public List<IntPtr> 被控句柄 = new List<IntPtr>();
        public List<dmsoft> 大漠集合 = new List<dmsoft>();
        public IKeyboardMouseEvents 全局HOOK;

        public 控制窗體()
        {
            InitializeComponent();
            self = this;
            釋放插件();
        }

        private void 釋放插件()
        {
            if (File.Exists("lib.dll") == false)
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                BufferedStream input = new BufferedStream(assembly.GetManifestResourceStream("同步器.Resources.lib.dll"));
                FileStream output = new FileStream("lib.dll", FileMode.Create);
                byte[] data = new byte[1024];
                int lengthEachRead;
                while ((lengthEachRead = input.Read(data, 0, data.Length)) > 0)
                {
                    output.Write(data, 0, lengthEachRead);
                }
                output.Flush();
                output.Close();
            }

            if (File.Exists("lib.dll") == true)
            {
                dmsoft 大漠 = null;
                try
                {
                    大漠 = new dmsoft();
                }
                catch (Exception)
                {
                    Cli.Wrap("cmd.exe").WithArguments(new[] { "/c", "regsvr32 lib.dll" }).ExecuteAsync();
                }
                大漠.SetShowErrorMsg(0);
                var 註冊碼 = "";
                int 注册状态 = 大漠.Reg(註冊碼, "1234");
                if (注册状态 == 1)
                {
                    打印日誌("註冊成功");
                }
            }
        }

        private void 獲取句柄_Click(object sender, EventArgs e)
        {
            var frm = new 獲取句柄();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void 腳本管理_Click(object sender, EventArgs e)
        {
            var frm = new 腳本窗體();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void 獲取鼠標句柄()
        {
            POINTAPI point = new POINTAPI();
            GetCursorPos(ref point);
            int 句柄 = WindowFromPoint(point.X, point.Y);
            StringBuilder 標題 = new StringBuilder(256);
            GetWindowText(句柄, 標題, 256);
            ListViewItem item = new ListViewItem();
            item.Text = 句柄.ToString();
            item.SubItems.Add(標題.ToString());
            item.SubItems.Add("");
            item.SubItems.Add("");
            句柄集合.Items.Add(item);
        }


        private void 打印日誌(string 內容)
        {
            richTextBox1.AppendText(內容 + "\r\n");
        }

        private void 控制窗體_Load(object sender, EventArgs e)
        {

        }

        private void 控制窗體_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                獲取鼠標句柄();
            }

            if (e.KeyCode == Keys.F3)
            {
                int x = -1;
                int y = -1;
                控制端大漠.GetCursorPos(out x, out y);
                打印日誌(x.ToString() + "-" + y.ToString());
            }
        }

        private void 開啟同步_Click(object sender, EventArgs e)
        {
            全局HOOK = Hook.GlobalEvents();
            全局HOOK.KeyPress += 鍵盤輸入HOOK;
            全局HOOK.KeyDown += 粘貼按鍵HOOK;
            全局HOOK.MouseMove += 滑鼠移動HOOK;
            全局HOOK.MouseUp += 滑鼠抬起HOOK;
            全局HOOK.MouseDown += 滑鼠按下HOOK;
            全局HOOK.MouseWheel += 滑鼠滾輪HOOK;
            打印日誌("開啟同步");
        }


        private void 滑鼠滾輪HOOK(object sender, MouseEventArgs e)
        {
            if (控制端大漠 != null)
            {
                if (e.Delta > 0)
                {
                    foreach (var 大漠 in 大漠集合)
                    {
                        大漠.WheelUp();
                    }
                }
                else
                {
                    foreach (var 大漠 in 大漠集合)
                    {
                        大漠.WheelDown();
                    }
                }
            }
        }

        private void 滑鼠移動HOOK(object sender, MouseEventArgs e)
        {

            if (控制端大漠 != null)
            {
                int x = -1;
                int y = -1;
                控制端大漠.GetCursorPos(out x, out y);
                if (x >= 0 && y >= 0)
                {
                    foreach (dmsoft 大漠 in 大漠集合)
                    {
                        大漠.MoveTo(x, y);
                    }
                }
            }
        }

        private void 鍵盤輸入HOOK(object sender, KeyPressEventArgs e)
        {
            Task.Run(() =>
            {
                if (控制端大漠 != null)
                {
                    foreach (dmsoft 大漠 in 大漠集合)
                    {
                        大漠.SetWindowState(大漠.GetBindWindow(), 15);
                        大漠.KeyPress(e.KeyChar);
                    }
                }
            });

        }

        private void 粘貼按鍵HOOK(object sender, KeyEventArgs e)
        {
            if (e.Modifiers.CompareTo(Keys.Control) == 0 && e.KeyCode == Keys.V)
            {
                var 发送文本 = 發送中文.Text;
                if (控制端大漠 != null)
                {
                    foreach (dmsoft 大漠 in 大漠集合)
                    {
                        大漠.SetWindowState(大漠.GetBindWindow(), 1);
                        大漠.SendString(大漠.GetBindWindow(), 发送文本);
                    }
                }
            }
        }

        private void 滑鼠抬起HOOK(object sender, MouseEventArgs e)
        {

            if (控制端大漠 != null)
            {
                foreach (dmsoft 大漠 in 大漠集合)
                {
                    大漠.LeftUp();
                }
            }
        }

        private void 滑鼠按下HOOK(object sender, MouseEventArgs e)
        {

            if (控制端大漠 != null)
            {
                int x = -1;
                int y = -1;
                控制端大漠.GetCursorPos(out x, out y);
                打印日誌(x.ToString() + "-" + y.ToString());
                foreach (dmsoft 大漠 in 大漠集合)
                {

                    //大漠.MoveTo(x, y);
                    大漠.LeftDown();
                    大漠.LeftUp();
                }
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();
        }

        private void betterListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (句柄集合.SelectedItems.Count > 0)
            {
                var 選擇 = 句柄集合.SelectedItems[0];
                選擇.SubItems[3].Text = "控制端";
                控制端句柄 = int.Parse(選擇.Text);
                控制端大漠 = new dmsoft();
                控制端大漠.UnBindWindow();
                控制端大漠.SetShowErrorMsg(0);
                int 状态 = 控制端大漠.BindWindowEx(控制端句柄, "normal", "normal", "normal", "", 0);
                if (状态 == 1)
                {
                    選擇.SubItems[2].Text = "成功";
                }
                else
                {
                    選擇.SubItems[2].Text = "失敗";
                }

                大漠集合.Clear();
                foreach (ListViewItem item in 句柄集合.Items)
                {
                    if (item != 選擇)
                    {
                        int 句柄 = int.Parse(item.Text);
                        var 大漠 = new dmsoft();
                        大漠.UnBindWindow();
                        大漠.SetShowErrorMsg(0);
                        大漠.EnableFakeActive(1);
                        大漠.EnableMouseSync(1, 100);
                        int 绑定状态 = 大漠.BindWindowEx(句柄, "normal", "windows", "windows", "", 0);
                        if (绑定状态 == 1)
                        {
                            大漠集合.Add(大漠);
                            item.SubItems[2].Text = "成功";
                            item.SubItems[3].Text = "";
                        }
                        else
                        {
                            item.SubItems[2].Text = "失敗";
                            item.SubItems[3].Text = "";
                        }
                    }
                }
            }
        }


        private void 全部綁定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            大漠集合.Clear();
            foreach (ListViewItem item in 句柄集合.Items)
            {
                int 句柄 = int.Parse(item.Text);
                var 大漠 = new dmsoft();
                大漠.UnBindWindow();
                大漠.EnableFindPicMultithread(0);
                大漠.EnableShareDict(1);
                大漠.SetShowErrorMsg(0);
                大漠.EnableFakeActive(0);
                int 绑定状态 = 大漠.BindWindowEx(句柄, "normal", "windows", "windows", "", 0);
                if (绑定状态 == 1)
                {
                    大漠集合.Add(大漠);
                    item.SubItems[2].Text = "成功";
                }
                else
                {
                    item.SubItems[2].Text = "失敗";
                }
            }
        }

        private void 腳本管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new 腳本窗體();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void 統一大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string input = Interaction.InputBox("寬高設置", "寬高設置", "500,400");
            if (input != "" && input.Contains(",") == true)
            {
                int x = 0, y = 0;
                int 寬 = int.Parse(input.Split(',')[0]);
                int 高 = int.Parse(input.Split(',')[1]);
                foreach (ListViewItem item in 句柄集合.Items)
                {
                    var 句柄 = (IntPtr)int.Parse(item.Text);

                    公共函數.SetWindowPos(句柄, IntPtr.Zero, x, y, 寬, 高, 0);
                    x += 寬;
                    if (x + 寬 > Screen.PrimaryScreen.Bounds.Width)
                    {
                        x = 0;
                        y += 高;
                    }
                }
            }
        }

        private void 關閉同步_Click(object sender, EventArgs e)
        {
            if (全局HOOK != null)
            {
                全局HOOK.MouseMove -= 滑鼠移動HOOK;
                全局HOOK.MouseUp -= 滑鼠抬起HOOK;
                全局HOOK.MouseDown -= 滑鼠按下HOOK;
                全局HOOK.MouseWheel -= 滑鼠滾輪HOOK;
                全局HOOK.Dispose();
                打印日誌("關閉同步");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (var 大漠 in 大漠集合)
            {
                大漠.SendString(132292, "222");
            }
        }

        private void 輸入文本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("輸入文本", "輸入文本", "");
            if (input != "")
            {
                控制端大漠.SendString(控制端大漠.GetBindWindow(), input);
                foreach (var 大漠 in 大漠集合)
                {
                    大漠.SendString(大漠.GetBindWindow(), input);
                }
            }
        }

        private void 統一前台ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            句柄集合.Items.Clear();
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in 句柄集合.CheckedItems)
            {
                句柄集合.Items.Remove(item);
            }
        }

        private void 批量啟動ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new 批量啟動();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
}
