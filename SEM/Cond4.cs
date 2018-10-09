using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cond4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            int c = Convert.ToInt16(Console.ReadLine());
            int d = Convert.ToInt16(Console.ReadLine());
            if ((Math.Max(a, b) < Math.Min(c, d)) || (Math.Min(a, b) > Math.Max(c, d))) Console.WriteLine("Нет решения");
            else if ((Math.Min(a, b) <= Math.Min(c, d)) && (Math.Max(c, d) <= Math.Max(a, b)))
                Console.WriteLine("[" + Math.Min(c, d).ToString() + "," + Math.Max(c, d).ToString() + "]");
            else if ((Math.Min(c, d) <= Math.Min(a, b)) && (Math.Max(a, b) <= Math.Max(c, d)))
                Console.WriteLine("[" + Math.Min(a, b).ToString() + "," + Math.Max(a, b).ToString() + "]");
            else Console.WriteLine("[" + Math.Max(a, c).ToString() + "," + Math.Min(b, d).ToString() + "]");
            Console.ReadKey();
        }
    }
}
