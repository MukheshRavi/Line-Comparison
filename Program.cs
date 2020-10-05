using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem");
            Console.WriteLine("Enter the co-ordinates of one end of line in x,y format");
            string[] frstCoordinate = (Console.ReadLine()).Split(",");
            double x1 = Convert.ToDouble(frstCoordinate[0]);
            double y1 = Convert.ToDouble(frstCoordinate[1]);
            Console.WriteLine("Enter the co-ordinates of other end in x,y format");
            string[] secondCoordinate = (Console.ReadLine()).Split(",");
            double x2 = Convert.ToDouble(secondCoordinate[0]);
            double y2 = Convert.ToDouble(secondCoordinate[1]);
            double lengthOfLine = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            Console.WriteLine("Length of given line is {0}", lengthOfLine);
        }
    }
}
