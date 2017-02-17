using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___TwoNumberSwap
{
    class Program
    {

        static void Swap(int a, int b)
        {
            a += b;
            b = a - b;
            a = a - b;
            Console.WriteLine("{0}, {1}", a, b);
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Print two numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Swap(a, b);
        }
    }
}
