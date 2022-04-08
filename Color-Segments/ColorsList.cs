using System;
using System.Collections.Generic;
using System.Text;

namespace Color_Segments
{
    class ColorsList
    {

        static public ColorsList Load(string filename)
        {
            ColorsList list = new ColorsList();
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(filename))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');

                        Color color = new Color(data[2]);
                        list.Add(color);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return list;
        }

        public bool CheckColorToListColor(Color color)
        {
            bool candidate = false;
            foreach (Color item in _colorsList)
            {
                if (item.ColorValue == color.ColorValue)
                {
                    candidate = true;
                }
            };

            return candidate;
        }
        private void Add(Color color)
        {
            _colorsList.Add(color);
        }
        private List<Color> _colorsList = new List<Color>();

    }
}
