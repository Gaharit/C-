using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Time_NoCycles_
{
    class Program
    {
        static void Angle()
        {
            int time;
            Console.WriteLine("Enter a number of hours: ");
            time = int.Parse(Console.ReadLine());
            if (time < 0)
                Console.WriteLine("You cheater! :P\n");
            else if (time < 7)
                Console.WriteLine("The angle is: {0}\n", time * 30);
            else if (time < 13)
                Console.WriteLine("The angle is: {0}\n", (time - 6) * 30);
            else if (time < 19)
                Console.WriteLine("The angle is: {0}\n", (time - 12) * 30);
            else if (time < 25)
                Console.WriteLine("The angle is: {0}\n", (time - 18) * 30);
            else Console.WriteLine("You cheater! :P\n");
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine();
                Angle();
                Console.WriteLine("Want to go again?");
            } while (Console.ReadLine() != "no");
        }
    }
}
