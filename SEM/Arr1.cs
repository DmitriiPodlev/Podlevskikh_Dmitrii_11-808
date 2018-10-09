using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arr1
{
    class Program
    {
        static void Main(string[] args)
        {
            // размер массива
            var n = int.Parse(Console.ReadLine());
            // количесвто сдвигов вправо
            var k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            // вводим массив
            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(Console.ReadLine());
            // цикл, отвечающий за количество сдвигов вправо
            for (int j = 0; j < k; j++)
            {
                // переменная, отвечающая за лишний элемент
                int value = arr[n - 1];
                // сдвигаем вправо массив
                for (int i = n - 1; i >= 1; i--)
                    arr[i] = arr[i - 1];
                // переменная заносится на 0 позицию
                arr[0] = value;
            }
            // выводим массив
            for (int i = 0; i < n; i++)
                Console.Write(arr[i].ToString() + " ");
            Console.ReadKey();
        }
    }
}
