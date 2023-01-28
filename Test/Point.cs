using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void ChangePosition(Point point)
        {
            this.x += point.x;
            this.y += point.y;
        }

        public override bool Equals(object? obj)
        {
            return obj is Point point &&
                   x == point.x &&
                   y == point.y;
        }
    }
}
