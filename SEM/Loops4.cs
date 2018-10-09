using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops4
{
    class Program
    {
        static void Main(string[] args)
        {
            var allNumber = int.Parse(Console.ReadLine());
            int[] mas;
            mas = new int[allNumber];
            int max = 0;
            int ch = 1;
            for (int i = 0; i < allNumber; i++)
              mas[i] = int.Parse(Console.ReadLine());
            for  (int i = 1; i <= allNumber - 1; i++)
            {
                if (mas[i - 1] == mas[i]) ch++;
                else if (max < ch)
                {
                    max = ch;
                    ch = 1;
                }
            }
            if (max < ch) max = ch;
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
