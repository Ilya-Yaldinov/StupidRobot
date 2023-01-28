using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Robot
    {
        public Point StartPoint { get; private set; }
        public Point EndPoint { get; private set; }
        public List<string> Steps { get; private set; }

        public Robot(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            Steps = new List<string>();
        }

        public void AddStep(string step)
        {
            Steps.Add(step);
        }
    }
}
