using System;
using System.Runtime.InteropServices;
using System.Text;

namespace 同步器
{
    public struct Rect
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }

    public static class 公共函數
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll", SetLastError = true)]
        public extern static uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

        [DllImport("user32.dll")]
        public extern static bool PostMessage(IntPtr hWnd, uint Msg, int wParam, uint lParam);

        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        public extern static IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpClassName, string lpWindowName);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINTAPI { public int X; public int Y; }

        [DllImport("user32.dll", EntryPoint = "GetCursorPos")]
        public static extern int GetCursorPos(ref POINTAPI lpPoint);

        [DllImport("user32.dll", EntryPoint = "WindowFromPoint")]
        public static extern int WindowFromPoint(int xPoint, int yPoint);

        [DllImport("user32.dll", EntryPoint = "GetWindowText")]
        public static extern int GetWindowText(int hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", EntryPoint = "GetClassName")]
        public static extern int GetClassName(int hWnd, StringBuilder lpString, int nMaxCont);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MoveWindow(IntPtr hWnd, int x, int y, int nWidth, int nHeight, bool BRePaint);

        [DllImport("user32.dll")]
        public static extern int GetWindowRect(int hwnd, out Rect lpRect);

        [DllImport("user32.dll")]
        public static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);

        [DllImport("user32.dll")]
        public static extern int EnumWindows(EnumWindowsCallback callPtr, int lParam);



        public delegate bool EnumWindowsCallback(IntPtr hwnd, int lParam);


        public static string 獲取進程名(int 句柄)
        {
            return "";
        }

        public static void 打印日誌(string 內容)
        {
            控制窗體.self.richTextBox1.AppendText(內容 + "\r\n");
        }

        public static void 坐標點擊(IntPtr 句柄, int x, int y)
        {

        }

        public static void 輸入文本(IntPtr 句柄, string 文本)
        {

        }

        public static void 粘貼文本(IntPtr 句柄, string 文本)
        {

        }
    }
}
