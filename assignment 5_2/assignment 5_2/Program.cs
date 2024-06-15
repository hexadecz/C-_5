using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle r1 = new rectangle(6.0,5.0);

            Console.WriteLine($"Length: {r1.Length}");
            Console.WriteLine($"Width: {r1.Width}");
            Console.WriteLine($"Perimeter: {r1.Perimeter}");
            Console.WriteLine($"Area: {r1.Area}");

        }
    }

    class rectangle
    {
        private double length = 1;
        private double width = 1;

        public rectangle (double length, double width)
        {
           Length = length;
            Width = width;
          
        }

        public double Length
        {
            get { return length; }
            set
            {
                if (value < 0.0 || value > 20.0)
                { Length = value; }
            }
        }

        public double Width
        {
            get { return Width; }
            set
            {
                if (value < 0.0 || value > 20.0)
                { Width = value; }
            }       
        }
       public double Perimeter => 2 * (Length + Width); // Read-only property for perimeter
       public double Area => Length * Width;           // Read-only property for area


    }
}
