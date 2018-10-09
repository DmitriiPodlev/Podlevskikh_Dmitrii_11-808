using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cond1
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();
            char[] start0 = start.ToCharArray();
            char[] end0 = end.ToCharArray();
            if (Math.Abs(end0[1] - start0[1]) == Math.Abs(end0[0] - start0[0]))
            Сonsole.WriteLine("Корректный ход для слона");
           else Console.WriteLine("Некорректный ход для слона");

            if (((Math.Abs(end0[1] - start0[1]) == 2) && (Math.Abs(end0[0] - start0[0]) == 1)) 
               || ((Math.Abs(end0[1] - start0[1]) == 1) && (Math.Abs(end0[0] - start0[0]) == 2)))
                Console.WriteLine("Корректный ход для коня");
            else Console.WriteLine("Некорректный ход для коня");

            if (start0[0] == end0[0] || end0[1] == start0[1])
                Console.WriteLine("Корректный ход для ладьи");
            else Console.WriteLine("Некорректный ход для ладьи");

            if (start0[0] == end0[0] || end0[1] == start0[1] || Math.Abs(end0[1] - start0[1]) == Math.Abs(end0[0] - start0[0]))
                Console.WriteLine("Корректный ход для ферзя");
            else Console.WriteLine("Некорректный ход для ферзя");

            if ((Math.Abs(end0[1] - start0[1]) == 1) && (Math.Abs(end0[0] - start0[0]) == 1) || 
               ((Math.Abs(end0[1] - start0[1]) == 1) && (end0[0] == start0[0])) || ((Math.Abs(end0[0] - start0[0]) == 1) && (end0[1] == start0[1])))
                Console.WriteLine("Корректный ход для короля");
            else Console.WriteLine("Некорректный ход для короля");
        }
    }
}
