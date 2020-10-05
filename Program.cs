using System;
using System.Collections.Generic;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> length = new List<double>();
            Console.WriteLine("Welcome to Line Comparison Problem");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter the co-ordinates of one end of line " + i + "in x,y format");
                string[] frstCoordinate = (Console.ReadLine()).Split(",");
                double x1 = Convert.ToDouble(frstCoordinate[0]);
                double y1 = Convert.ToDouble(frstCoordinate[1]);
                Console.WriteLine("Enter the co-ordinates of other end in x,y format");
                string[] secondCoordinate = (Console.ReadLine()).Split(",");
                double x2 = Convert.ToDouble(secondCoordinate[0]);
                double y2 = Convert.ToDouble(secondCoordinate[1]);
                double lengthOfLine = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
                length.Add(lengthOfLine);
                Console.WriteLine("Length of given line is {0}", lengthOfLine);
            }
            if (length[0] == length[1])
                Console.WriteLine("Both lines are equal");
            if (length[0] > length[1])
                Console.WriteLine("line 1 is greater");
            else
                Console.WriteLine("line 2 is greater");
        }
    }
}
