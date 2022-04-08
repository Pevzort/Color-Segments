using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Color_Segments
{
    class SegmentsList
    {
        public static SegmentsList Load(string filename)
        {
            SegmentsList segmentsList = new SegmentsList();
            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Segment segment = new Segment(line);
                        segmentsList.Add(segment);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return segmentsList;
        }
        public Segment FindMaxSegmentByColor(Color color)
        {
            Segment candidate = _segmentsList[0];
            double maxLength = candidate.Length;
            foreach (Segment segment in _segmentsList)
            {
                if (segment.Color == color.ColorValue && maxLength < segment.Length)
                {
                    candidate = segment;
                }
            }
            return candidate;
        }
        private void Add(Segment segment)
        {
            _segmentsList.Add(segment);
        }
        private List<Segment> _segmentsList = new List<Segment>();
    }
}
