using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random x = new Random() ;
            int generated_number = x.Next(1,1001);
            Console.WriteLine("Guess a number between 1-1000\n To get correct answere enter 0");
            string y = Console.ReadLine();
            int z = Convert.ToInt32(y);
            bool iscorrect = false;

            while ( ! iscorrect)
            {
                if (generated_number < z)
                {
                    Console.WriteLine("Too high. Try again.");
                }
                else if (generated_number > z)
                {
                    Console.WriteLine("Too low. Try Agian.");
                }
                else if (z == 0)
                {
                    Console.WriteLine("Correct answer is:\n{0}", generated_number);
                }    
                else { iscorrect = true; }
            }
                Console.WriteLine("Congradulations. You guessed the number!\n If you want to exit enter -1");
        }
    }
}
