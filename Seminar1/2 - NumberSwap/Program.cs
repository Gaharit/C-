using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___NumberSwap
{
    class Program
    {

        static int Reverse(int num)
        {
            return (num % 10 * 100 + (num % 100 - num % 10) + num / 100);
        }

        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a 3-digit number: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", Reverse(num));
            Console.ReadKey();
        }
    }
}
