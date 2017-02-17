using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___prime_divisors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y, count = 0;
            Console.WriteLine("Enter a number:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter two prime divisors:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            n--;
            while (n != 0)
            {
                if (n % x == 0 || n % y == 0)
                    count++;
                n--;
            }
            Console.WriteLine("The answer is {0}", count);
            Console.ReadKey();
        }
    }
}
