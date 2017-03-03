using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void ChessTest(string position1, string position2)
        {
            Console.WriteLine("\nPossibility of this turn:\n");

            Console.Write("For bishop: ");
            if (BishopTest(position1, position2))
                Console.WriteLine("possible");
            else Console.WriteLine("impossible");

            Console.Write("For knight: ");
            if (KnightTest(position1, position2))
                Console.WriteLine("possible");
            else Console.WriteLine("impossible"); ;


            Console.Write("For rook: ");
            if (RookTest(position1, position2))
                Console.WriteLine("possible");
            else Console.WriteLine("impossible");

            Console.Write("For queen: ");
            if (RookTest(position1, position2) || BishopTest(position1, position2))
                Console.WriteLine("possible");
            else Console.WriteLine("impossible");

            Console.Write("For king: ");
            if (KingTest(position1, position2))
                Console.WriteLine("possible");
            else Console.WriteLine("impossible");

        }
        static bool BishopTest(string position1, string position2)
        {
            return (Math.Abs(position2[0] - position1[0]) == Math.Abs(position2[1] - position1[1]) &&
                (position2[0] - position1[0]) * (position2[1] - position1[1]) != 0);
        }

        static bool KnightTest(string position1, string position2)
        {
            return (Math.Abs(position2[0] - position1[0]) == 2 && Math.Abs(position2[1] - position1[1]) == 1 ||
                Math.Abs(position2[0] - position1[0]) == 1 && Math.Abs(position2[1] - position1[1]) == 2);
        }
        static bool RookTest(string position1, string position2)
        {
            return (position2[0] == position1[0] ^ position2[1] == position1[1]);
        }
        static bool KingTest(string position1, string position2)
        {
            return (Math.Max(Math.Abs(position2[0] - position1[0]), Math.Abs(position2[1] - position1[1])) == 1);
        }
        static bool CheckInput(string position)
        {
            if (position[0] < 'a' || position[0] > 'h' || position[1] < '1' || position[1] > '8')
                return false;
            return true;
        }
        static void Main(string[] args)
        {
                Console.WriteLine("Enter position 1 and position 2: ");
                string[] input = Console.ReadLine().Split(' ');
            if (!CheckInput(input[0]) || !CheckInput(input[1]))
            {
                Console.WriteLine("Wrong input.");
                Console.ReadKey();
                return;
            }
            ChessTest(input[0], input[1]);
            Console.ReadKey();
        }
    }
}
