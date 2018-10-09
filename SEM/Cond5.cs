using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cond5
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            double n = l / k;
            double tmin, tmax;
            if (l % k == 0)
            {
                tmin = n * h;
                Console.WriteLine(tmin.ToString() + " " + tmin.ToString());
            }
            else
            {
                tmin = n * h;
                tmax = n * h + h;
                Console.WriteLine(tmin.ToString() + " " + tmin.ToString());
            }
            Console.ReadKey();
        }
    }
}
