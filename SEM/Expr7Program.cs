using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // вводим коэффициенты уравнения прямой
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            // построим прямую, параллельную данной прямой
            Console.WriteLine("Параллельная прямая:");
            Console.WriteLine(k);
            Console.WriteLine(b - 1);
            // построим прямую, перпендикулярную данной прямой
            Console.WriteLine("Перпендикулярная прямая:");
            k = -1 / k;
            Console.WriteLine(k);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
