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
            double dirX = x2 - x1, dirY = y2 - y1, dirZ = z2 - z1; //Направляющий вектор
            double conX = x3 - x1, conY = y3 - y1, conZ = z3 - z1; //Вектор, соединяющий прямую и точку
            Console.WriteLine("The distance is: {0}", Math.Sqrt(Math.Pow(conY * dirZ - conZ * dirY, 2) + Math.Pow(conX * dirZ - conZ * dirX, 2) + Math.Pow(conX * dirY - conY * dirX, 2)) / (Math.Sqrt(Math.Pow(dirX, 2) + Math.Pow(dirY, 2) + Math.Pow(dirZ, 2))));
            Console.ReadKey();
        }
    }
}
