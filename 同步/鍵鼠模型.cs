using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using 動作模型命名空間;
using 同步器;

namespace 鍵鼠模型命名空間
{

    public class 鍵鼠模型
    {
        //private class Ktick
        //{
        //    public bool Down = false;
        //    public long Begin, End;
        //    public long[] Dtime = new long[16];
        //}

        //private static Dictionary<int, Ktick> Kstate = new Dictionary<int, Ktick>();
        //private static bool MousePress = false;
        //private static Thread MouseThread;
        //private static int[] Dspan = new int[16];
        //private static IKeyboardMouseEvents kmevent = Hook.GlobalEvents();
        //private static dmsoft 控制端大漠;
        //private static int dmX, dmY, dmW, dmH;
        //private static int Hid = 0;
        //public static int Delay = 0, PianYi = 0;



        //static 鍵鼠模型()
        //{
        //    控制端大漠 = new dmsoft();
        //    for (int i = 0; i < 223; i++)
        //    {
        //        Kstate.Add(i, new Ktick());
        //    }
        //}

        //private static void KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (!WorkInMain() || Kstate[e.KeyValue].Down)
        //    {
        //        return;
        //    };
        //    Kstate[e.KeyValue].Down = true;
        //    Kstate[e.KeyValue].Begin = DateTime.Now.Ticks + 10000;
        //    KeySims(增加控制.KeyDown, e.KeyValue);
        //}

        //private static void KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (!WorkInMain())
        //    {
        //        return;
        //    };
        //    Kstate[e.KeyValue].Down = false;
        //    Kstate[e.KeyValue].End = DateTime.Now.Ticks + 10000;
        //    KeySims(增加控制.KeyUp, e.KeyValue);
        //}

        //private static void KeySims(QueueFun fun, int code)
        //{
        //    Ktick kt = Kstate[code];
        //    for (int i = 0; i < 控制窗體.self.大漠集合.Count; i++)
        //    {
        //        if (控制窗體.self.大漠集合.Main)
        //        {
        //            continue;
        //        };
        //        if (kt.Down)
        //        {
        //            kt.Dtime[i] = kt.Begin + Dspan[i];
        //        }
        //        else
        //        {
        //            kt.Dtime[i] += (kt.End - kt.Begin);
        //        }
        //        控制窗體.self.大漠集合[i].AddMouse(new Act(kt.Dtime[i], fun, code));
        //    }
        //}



        //private static void MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (!WorkInMain() || !MouseInMain())
        //    {
        //        return;
        //    };
        //    if (e.Button.ToString() == "Left")
        //    {
        //        MouseSims(增加控制.LeftDown, dmX, dmY, 0);
        //    }
        //    else
        //    {
        //        MouseSims(增加控制.RightDown, dmX, dmY, 0);
        //    };
        //    MousePress = true;
        //}

        //private static void MouseUp(object sender, MouseEventArgs e)
        //{
        //    if (!WorkInMain())
        //    {
        //        return;
        //    };
        //    MousePress = false;
        //    控制端大漠.GetCursorPos(out dmX, out dmY);
        //    if (e.Button.ToString() == "Left")
        //    {
        //        MouseSims(增加控制.LeftUp, dmX, dmY, 2);
        //    }
        //    else
        //    {
        //        MouseSims(增加控制.RighttUp, dmX, dmY, 2);
        //    }
        //}

        //private static void MouseSims(QueueFun fun, int x, int y, int state = 0)
        //{
        //    long nows = DateTime.Now.Ticks + 10000; int cu = 0;
        //    int nx = x, ny = y;
        //    for (int i = 0; i < 控制窗體.self.大漠集合.Count; i++)
        //    {
        //        if (G.Sims[i].Main)
        //        { continue; };
        //        long tick;
        //        if (state == 0)
        //        {
        //            cu += Delay > 0 ? G.Ran.Next(0, Delay) : 0; Dspan[i] = cu;
        //        }
        //        tick = nows + Dspan[i];
        //        if (PianYi > 0)
        //        {
        //            int ux = G.Ran.Next(-PianYi, PianYi), uy = G.Ran.Next(-PianYi, PianYi);
        //            if (state == 1) { nx += ux; ny += uy; } else { nx += ux / 2; ny += uy / 2; }
        //        }
        //        G.Sims[i].AddMouse(new Act(tick, fun, nx, ny));
        //    }
        //}

        //private static void MouseLoop()
        //{
        //    int x = 0, y = 0;
        //    while (true)
        //    {
        //        if (!MousePress || !WorkInMain())
        //        {
        //            continue;
        //        }
        //        控制端大漠.GetCursorPos(out x, out y); if (dmX == x && dmY == y) { continue; }
        //        dmX = x; dmY = y;
        //        MouseSims(增加控制.MoveTo, x, y, 1);
        //        Thread.Sleep(10);
        //    }
        //}


        //private static void Wheels(object sender, MouseEventArgs e)
        //{
        //    if (WorkInMain())
        //    {
        //        int x, y; 控制端大漠.GetCursorPos(out x, out y);
        //        for (int i = 0; i < 控制窗體.self.大漠集合.Count; i++)
        //        {
        //            if (!控制窗體.self.大漠集合[i].Main)
        //            {
        //                if (e.Delta > 0)
        //                {
        //                    增加控制.WheelUp(控制窗體.self.大漠集合[i], x, y);
        //                }
        //                else
        //                {
        //                    增加控制.WheelDown(控制窗體.self.大漠集合[i], x, y);
        //                }
        //            };
        //        }
        //    }
        //}


        //private static bool WorkInMain()
        //{
        //    return 控制端大漠.GetForegroundWindow() == Hid;
        //}

        //private static bool MouseInMain()
        //{
        //    控制端大漠.GetCursorPos(out dmX, out dmY);
        //    return (dmX < 0 || dmY < 0 || dmX > dmW || dmY > dmH) ? false : true;
        //}

        //public static void Dispose()
        //{
        //    kmevent.Dispose();
        //    kmevent = null;
        //    控制端大漠 = null;
        //}
    }



}

