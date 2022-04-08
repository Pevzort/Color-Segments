using System;
using System.Collections.Generic;
using System.Text;

namespace Color_Segments
{
    class Color
    {
        public Color(string color)
        {
            _color = color;
        }
        static public Color ReadFromKbd()
        {
            Console.WriteLine("Enter color");
            string result = Console.ReadLine();
            while (result.Trim() == "")
            {
                Console.WriteLine("Enter color");
                result = Console.ReadLine();
            }
            return new Color(result);
        }
        public string ColorValue { get { return _color; } }

        private string _color;
    }
}
