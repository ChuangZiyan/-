using System.Threading;
using WP;

namespace 動作模型命名空間
{

    public delegate void QueueFun(Sim sim, int par1 = 0, int par2 = 0);

    public class 動作模型
    {
        public long Tick;
        private int Par1, Par2;
        private QueueFun Fun;
        public 動作模型(long tick, QueueFun fun, int par1 = 0, int par2 = 0) { Tick = tick; Fun = fun; Par1 = par1; Par2 = par2; }

        public void Run(Sim sim)
        {
            Fun(sim, Par1, Par2); Fun = null;
        }
    }


    public static class 增加控制
    {

        public static void KeyDown(dmsoft 大漠, int code, int par1 = 0)
        {
            大漠.KeyDown(code);
        }

        public static void KeyUp(dmsoft 大漠, int code, int par1 = 0)
        {
            大漠.KeyUp(code);
        }


        public static void MoveTo(dmsoft 大漠, int x, int y)
        {
            大漠.MoveTo(x, y);

        }

        public static void LeftDown(dmsoft 大漠, int x, int y)
        {
            大漠.MoveTo(x, y);
            大漠.LeftDown();
        }

        public static void LeftUp(dmsoft 大漠, int x, int y)
        {
            大漠.MoveTo(x, y);
            大漠.LeftUp();
        }


        public static void LeftClick(dmsoft 大漠, int x, int y)
        {
            大漠.MoveTo(x, y);
            大漠.LeftDown();
            大漠.LeftUp();

        }

        public static void RightDown(dmsoft 大漠, int x, int y)
        {
            大漠.MoveTo(x, y);
            大漠.RightDown();
        }

        public static void RighttUp(dmsoft 大漠, int x, int y)
        {
            大漠.MoveTo(x, y);
            大漠.RightUp();

        }

        public static void WheelUp(dmsoft 大漠, int x = 0, int y = 0)
        {
            大漠.MoveTo(x, y);
            大漠.WheelUp();

        }
        public static void WheelDown(dmsoft 大漠, int x = 0, int y = 0)
        {
            大漠.MoveTo(x, y);
            大漠.WheelDown();
        }

    }


}
