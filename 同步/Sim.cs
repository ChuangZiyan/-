using System;
using System.Collections.Generic;
using System.Threading;
using System.Collections;
using System.Linq;
using System.IO;

namespace WP
{
    public class Sim
    {
        public int Hid;
        public string Tit;
        public bool Main = false;
        public dmsoft 大漠;
        public Thread thread;
        public Queue Kqueue, Mqueue;
        public Thread GuaThread;
        public int RowId = 0;
        public Sim(int hid, bool main)
        {
            Hid = hid;
            Main = main;
        }
    }
}
