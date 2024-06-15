using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_5_1
{
    internal class Program
    {
        class Rectangle
        {
            private int length;
            private int width;

            public Rectangle(int length, int width)
            {
                length = 1;
                width = 1;
            }

        }
        static void Main(string[] args)
        {
            Rectangle x =  new Rectangle(5,6);
        }
    }
}
