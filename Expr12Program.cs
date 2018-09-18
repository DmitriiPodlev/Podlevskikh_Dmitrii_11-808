using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr12
{
    class Program
    {
        static void Main(string[] args)
        {
            // h - высота, х - скорость, когда у пассажиров закладывает уши, v - скорость
            //t - время полета, tMin - минимальное время, tMax - максимальное время
            int h = Convert.ToInt16(Console.ReadLine());
            int t = Convert.ToInt16(Console.ReadLine());
            int v = Convert.ToInt16(Console.ReadLine());
            int x = Convert.ToInt16(Console.ReadLine());
            double tMin = (h - x * t) / (v - x);
            int tMax = t;
            Console.WriteLine(tMin.ToString() + " " + tMax.ToString());
            Console.ReadKey();
        }
    }
}
