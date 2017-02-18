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
            Console.WriteLine("Angle is {0}", (Math.Abs(6 - Math.Abs(time - 6))) * 30);
        }
        static void Main(string[] args)
        {
            Angle();
            Console.ReadKey();
        }
    }
}
