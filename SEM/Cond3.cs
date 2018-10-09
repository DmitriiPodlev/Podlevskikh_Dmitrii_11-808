using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cond3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt16(Console.ReadLine());
            int number1 = number / 1000;
            int sum1 = number1 / 100 + number1 / 10 % 10 + number1 % 10; 
            int number2 = number % 1000;
            int sum2 = number2 / 100 + number2 / 10 % 10 + number2 % 10;
            if (((sum1 == sum2 + 1) && (number2 % 10 != 9)) || (number1 == number2 + 1)) Console.WriteLine("Следующий билет счастливый");
            else if (((sum2 == sum1 + 1) && (number1 % 10 != 9)) || (number == number + 1)) Console.WriteLine("Предыдущий билет счастливый");
            else if (sum2 == sum1) Console.WriteLine("Билет счастливый");
            else Console.WriteLine("Билет несчастливый");
        }
    }
}
