using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{
    class Program
    {
        static void Main(string[] args)
        {
            // обозначим разряды, с помощью них переворачиваем наше число
            int a1, a2, a3;
            int  a = Convert.ToInt16(Console.ReadLine());
            a1 = a / 100;
            a2 = a / 10 % 10;
            a3 = a % 10;
            a = a3 * 100 + a2 * 10 + a1;
            Console.WriteLine(a);
        }
    }
}
