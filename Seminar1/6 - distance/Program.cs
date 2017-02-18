using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___distance
{
    class Program
    {
        static double x1 = 1.0, y1 = 2.0, z1 = 3.0; //координаты первой точки прямой
        static double x2 = 4.0, y2 = 5.0, z2 = 6.0; //координаты второй точки прямой
        static double x3 = 15.0, y3 = 17.0, z3 = 25.0; //координаты точки, не принадлежащей прямой

        static void Main(string[] args)
        {
            double directionX = x2 - x1, directionY = y2 - y1, directionZ = z2 - z1; //Направляющий вектор
            double connectionX = x3 - x1, connectionY = y3 - y1, connectionZ = z3 - z1; //Вектор, соединяющий прямую и точку
            double dividend = Math.Sqrt(Math.Pow(connectionY * directionZ - connectionZ * directionY, 2) + Math.Pow(connectionX * directionZ - connectionZ * directionX, 2) + Math.Pow(connectionX * directionY - connectionY * directionX, 2));
            double divisor = Math.Sqrt(Math.Pow(directionX, 2) + Math.Pow(directionY, 2) + Math.Pow(directionZ, 2));
                Console.WriteLine("The distance is: {0}",  dividend/divisor);
            Console.ReadKey();
        }
    }
}
