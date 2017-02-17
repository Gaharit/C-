using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___leap
{
    class Program
    {
        static int count;

        static int Leap(int a, int b)
        {
            if (a == b)
                return 0;
            if ((a % 4 == 0 && a % 100 != 0) || a % 400 == 0)
            {
                count++;
            }
            a++;
            return Leap(a, b);
        }

        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter a range of years:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Leap(a, b);
            Console.WriteLine("{0}", count);
            Console.ReadKey();
        }
    }
}
