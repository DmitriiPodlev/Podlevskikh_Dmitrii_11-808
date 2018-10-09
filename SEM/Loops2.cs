using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int count = 0, sot, dec, ed;
            // разбиваем число на сотни десятки и единицы
            for (sot = 1; sot <= 9; sot++)
                for (dec = 0; dec <= 9; dec++)
                    for (ed = 0; ed <= 9; ed++)
                        if (sot + dec + ed == n) count++;
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
