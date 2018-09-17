using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar5
{
    class Program
    {
        static void Main(string[] args)
        {
            // а и b - промежутки годов
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            // countYear количество високосных лет
            int countYear;
            countYear = (b / 4 - b / 100 + b / 400) - (a / 4 - a / 100 + a / 400) + 1;
            Console.WriteLine(countYear);
            Console.ReadKey();
        }
    }
}
