using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar4
{
    class Program
    {
        static void Main(string[] args)
        {// N - количество чисел
            // X, Y -простые делители
            // k - количество искомых чисел 
            int N = Convert.ToInt16(Console.ReadLine());
            int X = Convert.ToInt16(Console.ReadLine());
            int Y = Convert.ToInt16(Console.ReadLine());
            int k = (N - 1) / X + (N - 1) / Y - (N - 1) / (X * Y);
            Console.WriteLine(k);
        }
    }
}
