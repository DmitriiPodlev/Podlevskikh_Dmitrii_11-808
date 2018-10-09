using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arr2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            // вводим размер массива
            var n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            // отвечает за число в десятичной системе счисления
            int tenNumberSystem = 0;
            // вводим массив
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());
            // длина символов в массиве
            int length = arr.Length;
            if (a != 10)
                tenNumberSystem = GetValueOnTenNumberSystem(tenNumberSystem, a, length, arr);
            if (b == 10)
                Console.WriteLine(tenNumberSystem);
            else
                GetValueFromTenNumberSystem(tenNumberSystem, b);
            Console.ReadKey();
        }
        // перевод числа в десятичную систему счисления
        static int GetValueOnTenNumberSystem(int tenNumberSystem, int a, int length, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                tenNumberSystem = (int)(tenNumberSystem + arr[i] * Math.Pow(a, length - 1));
                length--;
            }
            return tenNumberSystem;
        }
        // перевод числа из десятичной системы счисления
        static void GetValueFromTenNumberSystem(int tenNumberSystem, int b)
        {
            // остаток от деления
            int residue;
            // будущее переведенное число
            int answer = 0;
            while (tenNumberSystem > 0)
            {
                residue = (int)tenNumberSystem % b;
                answer = answer * 10 + residue;
                tenNumberSystem = tenNumberSystem / b;
            }
            // реверс строки, вывод искомого числа
            string answerArr = answer.ToString();
            char[] s = answerArr.ToCharArray();
            Array.Reverse(s);
            Console.WriteLine(s);
        }
    }
}
