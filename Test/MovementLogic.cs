using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class MovementLogic
    {
        public Dictionary<string, Action> Movement { get; private set; }
        public Point CurrentPoint { get; private set; }

        public MovementLogic(Point point)
        {
            Movement = new Dictionary<string, Action>();
            this.CurrentPoint = point;
            InitMovement();
        }

        private void InitMovement()
        {
            Movement.Add("u", () => CurrentPoint.ChangePosition(new Point(0, 1)));
            Movement.Add("d", () => CurrentPoint.ChangePosition(new Point(0, -1)));
            Movement.Add("r", () => CurrentPoint.ChangePosition(new Point(1, 0)));
            Movement.Add("l", () => CurrentPoint.ChangePosition(new Point(-1, 0)));
            Movement.Add("dul", () => CurrentPoint.ChangePosition(new Point(-1, 1)));
            Movement.Add("dur", () => CurrentPoint.ChangePosition(new Point(1, 1)));
            Movement.Add("ddl", () => CurrentPoint.ChangePosition(new Point(-1, -1)));
            Movement.Add("ddr", () => CurrentPoint.ChangePosition(new Point(1, -1)));
        }
    }
}
