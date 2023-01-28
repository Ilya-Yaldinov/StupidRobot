using Test;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main()
        {
            FileParser fileReader = new FileParser("test.txt");
            Robot robot = fileReader.ParseFile();
            MovementLogic movementLogic = new MovementLogic(robot.StartPoint);
            foreach(string direction in robot.Steps)
            {
                if (movementLogic.Movement.ContainsKey(direction))
                {
                    movementLogic.Movement[direction].Invoke();
                }
            }

            Console.Write(robot.EndPoint.Equals(movementLogic.CurrentPoint));
        }
    }
}