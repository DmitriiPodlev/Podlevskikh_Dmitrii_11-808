using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6
{
    class Program
    {
        static void Main(string[] args)
        {
            // координаты точки
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            // координаты двух точек прямой
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            // уравнение прямой
            double s1 = Math.Sqrt(Math.Pow(y3 - y2, 2) + Math.Pow(x3 - x2, 2));
            // находим уравнения прямых от заданной точки до точек, принадлежащих концам отрезка прямой
            double s2 = Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(x2 - x1, 2));
            double s3 = Math.Sqrt(Math.Pow(y3 - y1, 2) + Math.Pow(x3 - x1, 2));
            // получив три стороны, найдем площадь треугольника через полупериметр
            double p = (s1 + s2 + s3) / 2;
            double S = Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3));
            // найдем искомое расстояние через сторону
            double h = S / 0.5 / s1;
            Console.WriteLine(h);
            Console.ReadKey();
        }
    }
}
