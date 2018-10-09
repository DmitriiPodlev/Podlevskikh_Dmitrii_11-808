using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int n1 = 0;
            // получение числа в обратном порядке
            while (n > 0)
            {
                n1 = n1 * 10 + n % 10;
                n = n / 10; 
            }
            Console.WriteLine(n1);
            Console.ReadKey();
        }
    }
}
