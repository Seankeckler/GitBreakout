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
            int num = int.Parse(input);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i+1);
            }
        }
    }
}
