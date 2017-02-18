using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_divisors
{
    class Program
    {
        static int max = 1000, divisor1 = 3, divisor2 = 5;
        static void Main(string[] args)
        {
            int sum = 0, suspect;
            for(suspect = max - 1; suspect>0; suspect--)
            {
                if (suspect % divisor1 == 0 || suspect % divisor2 == 0)
                    sum += suspect;
            }
            Console.WriteLine("Sum of all positive numbers less than {0} than can be divided by {1} or {2} is {3}", max, divisor1, divisor2, sum);
            Console.ReadKey();
        }
    }
}
