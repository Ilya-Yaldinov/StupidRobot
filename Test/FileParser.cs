using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class FileParser
    {
        private const int direction = 0;
        private const int repetitionQuantity = 1;
        private const int coordX = 0;
        private const int coordY = 1;

        private string file;
        private Robot robot;

        public FileParser(string file)
        {
            this.file = file;
        }

        public Robot ParseFile()
        {
            string[] lines = File.ReadAllLines(file);
            string[] firstPoint = lines[0].Split(";");
            string[] lastPoint = lines[1].Split(";");
            robot = new Robot(new Point(int.Parse(firstPoint[coordX]), int.Parse(firstPoint[coordY])),
                new Point(int.Parse(lastPoint[coordX]), int.Parse(lastPoint[coordY])));
            for(int i = 2; i < lines.Length; i++)
            {
                AddStepsToList(lines[i]);
            }

            return robot;
        }

        private void AddStepsToList(string line)
        {
            string[] step = line.Split(" ");
            for(int i = 0; i < int.Parse(step[repetitionQuantity]); i++)
            {
                robot.Steps.Add(step[direction]);
            }
        }
    }
}
