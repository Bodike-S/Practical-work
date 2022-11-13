using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace Pr1
{
    public class Point
    {
        private int x = 0;
        private int y = 0;

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        internal int[,] GetXYPair(int _x, int _y)
        {
            int[,] array = new int[_x, _y];
            return array;
        }
        protected internal double Distance(int _x, int _y)
        {
            return Math.Sqrt(Math.Pow(_x - x, 2) + Math.Pow(_y - y,2));
        }
        protected internal double Distance(Point p)
        {
            return Math.Sqrt(Math.Pow(p.x - x, 2) + Math.Pow(p.y - y, 2));
        }
        public static explicit operator double(Point p)
        {
            return Math.Sqrt(Math.Pow(p.x, 2) + Math.Pow(p.y, 2));
        }
    }
}
