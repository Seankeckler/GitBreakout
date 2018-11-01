using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBreakout
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();

            // Validation for number input (while false, console prints)
            while(!(int.TryParse(input, out int num)))
            {
                Console.WriteLine("That is not a number you dummy!");
            }

        }
    }
}
