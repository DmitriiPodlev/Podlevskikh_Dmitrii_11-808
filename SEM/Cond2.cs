using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cond2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt16(Console.ReadLine());
            int y = Convert.ToInt16(Console.ReadLine());
            int z = Convert.ToInt16(Console.ReadLine());
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            // сравниваем размеры
            if (((x <= a) && (y <= b)) || ((x <= b) && (y <= a))) Console.WriteLine("Пролезет"); 
            else if (((x <= a) && (z <= b)) || ((x <= b) && (z <= a))) Console.WriteLine("Пролезет");
            else if (((y <= a) && (z <= b)) || ((y <= b) && (z <= a))) Console.WriteLine("Пролезет");
            else Console.WriteLine("Не пролезет");
        }
    }
}
