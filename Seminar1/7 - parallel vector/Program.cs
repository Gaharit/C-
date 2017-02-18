using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___parallel_vector
{
    class Program
    {
        static int x1 = 3, y1 = 5, z1 = 1; //координаты первой точки прямой
        static int x2 = 7, y2 = 2, z2 = 9; //координаты второй точки прямой
        static void Main(string[] args)
        {
            Console.WriteLine("A straight is defined by two points: ({0},{1},{2}) and ({3},{4},{5})", x1, y1, z1, x2, y2, z2);
            Console.WriteLine("Vector ({0},{1},{2}) is parallel to this straight", x2 - x1, y2 - y1, z2 - z1);
            Console.WriteLine("Vector ({0},{1},{2}) is perpendicular to this straight", y1 - y2, x2 - x1, x1 * y2 - x2 * y1);
            Console.ReadKey();
        }
    }
}
