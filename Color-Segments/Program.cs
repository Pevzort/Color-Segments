using System;

namespace Color_Segments
{
    class Program
    {
        static void Main(string[] args)
        {
            SegmentsList segmentsList = SegmentsList.Load("../../../data/segments-input.txt");
            ColorsList colorsList = ColorsList.Load("../../../data/segments-input.txt");
            Color color = Color.ReadFromKbd();
            bool candidate = colorsList.CheckColorToListColor(color);
            while (!candidate)
            {
                Console.WriteLine("Color not found");
                color = Color.ReadFromKbd();
            }
            Segment foundSegment = segmentsList.FindMaxSegmentByColor(color);
            foundSegment.Print();
        }
    }
}
