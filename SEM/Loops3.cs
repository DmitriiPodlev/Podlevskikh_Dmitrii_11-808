using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops3
{
    class Program
    {
        static void Main(string[] args)
        {
            // number - вводимое число, length - длина до вводимого числа, lengthNumber - числа до вводимого числа
            var number = int.Parse(Console.ReadLine());
            int length = 0, lengthNumber = 0;
            while (length < number)
            {
                lengthNumber++;
                length += (int)Math.Floor(Math.Log10(lengthNumber)) + 1;
            }
            int digit = lengthNumber / (int)(Math.Pow(10, length - number)) % 10;
            Console.WriteLine(digit);
            Console.ReadKey();
        }
    }
}
