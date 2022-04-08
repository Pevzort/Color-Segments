using System;
using System.Drawing;

namespace Color_Segments
{
    class Segment
    {
        public Segment(string line)
        {
            string[] data = line.Split('|');
            string[] dataPointStart = data[0].Split('x');
            string[] dataPointEnd = data[1].Split('x');

            _start = new Point(Convert.ToInt32(dataPointStart[0]), Convert.ToInt32(dataPointStart[1]));
            _end = new Point(Convert.ToInt32(dataPointEnd[0]), Convert.ToInt32(dataPointEnd[1]));
            _color = data[2];
        }
        public void Print() {
            Console.WriteLine($"Color: {Color}, Length: {Length}");
        }
        public string Color { get { return _color; } }
        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow(_end.X - _start.X, 2) + Math.Pow(_end.Y - _start.Y, 2));
            }
        }

        private Point _start;
        private Point _end;
        private string _color;
    }
}
