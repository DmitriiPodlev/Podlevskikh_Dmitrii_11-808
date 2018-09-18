using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskProcents
{
    class Program
    {
        public static double Calculate(string userInput)
        {
            // вводим S0 - начальная сумма, procent - годовая ставка, timeProcent - время вклада
            var text = userInput.Split();
            double S0 = double.Parse(text[0]);
            double procent = double.Parse(text[1]);
            int timeProcent = int.Parse(text[2]);
            return S0 * Math.Pow(procent / 12 / 100 + 1, timeProcent);
        }
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            double a = Calculate(userInput);
            Console.WriteLine(a);
        }
    }
}
