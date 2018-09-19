using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr10
{
    class Program
    {
        static void Main(string[] args)
        {
            // S1 - сумма всех чисел, кратных 3 
            // S2 - сумма всех чисел, кратных 5
            // S3 - сумма всех чисел, кратных 15
            // S4 - искомая сумма
            int S1 = ((2 * 3 + 3 * (333 - 1)) / 2) * 333;
            int S2 = ((2 * 5 + 5 * (199 - 1)) / 2) * 199;
            int S3 = ((2 * 15 + 15 * (66 - 1)) / 2) * 66;
            int S4 = S1 + S2 - S3;
            Console.WriteLine(S4);
            Console.ReadKey();
        }
    }
}
