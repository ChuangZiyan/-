using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using static 同步器.公共函數;

namespace 同步器.窗體
{
    public partial class 獲取句柄 : Form
    {
        public static Dictionary<string, string> 句柄類型集合 = new Dictionary<string, string>();

        public static string 選擇類型;
        public 獲取句柄()
        {
            InitializeComponent();

        }

        private void 獲取句柄_Load(object sender, EventArgs e)
        {
            句柄類型.SelectedIndex = 0;
            句柄類型集合.Clear();
            句柄類型集合.Add("瀏覽器", "Chrome_WidgetWin_1");
            句柄類型集合.Add("模擬器", "LDPlayerMainFrame");
            句柄類型集合.Add("虛擬機", "Chrome_WidgetWin_1");
        }

        public static bool 遍歷頂層句柄(IntPtr 句柄, int lParam)
        {
            StringBuilder 類名 = new StringBuilder(256);
            GetClassName((int)句柄, 類名, 256);

            StringBuilder 標題 = new StringBuilder(256);
            GetWindowText((int)句柄, 標題, 256);

            Rect rect;
            GetWindowRect((int)句柄, out rect);
            int 宽 = rect.Right - rect.Left;
            int 高 = rect.Bottom - rect.Top;

            if (類名.ToString() == 句柄類型集合[選擇類型].ToString() && 標題.ToString() != "")
            {
                ListViewItem item = new ListViewItem();
                item.Text = 句柄.ToString();
                item.SubItems.Add(標題.ToString());
                item.SubItems.Add("");
                item.SubItems.Add(宽.ToString() + "*" + 高.ToString());
                item.SubItems.Add("");
                控制窗體.self.句柄集合.Items.Add(item);
            }
            return true;
        }

        private void 獲取_Click(object sender, EventArgs e)
        {
            選擇類型 = 句柄類型.Text.Trim();
            控制窗體.self.句柄集合.Items.Clear();
            EnumWindowsCallback callBackFn = new EnumWindowsCallback(遍歷頂層句柄);
            EnumWindows(callBackFn, 0);
            this.Hide();
        }
    }
}
