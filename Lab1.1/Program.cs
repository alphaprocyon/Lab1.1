using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Вариант 9
namespace Lab1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int N = 10;
            var array = new int[N];
            var random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
            }
            PrintL(array);

            FirstPart(array);
            SecondPart(array);
            ThirdPart(array);
            Console.ReadKey();
        }
        static void FirstPart(int[] array) {
           
            int minx = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < minx) {
                    minx = Math.Abs(array[i]);
                }
            }

            Console.WriteLine("Минимальный по модулю:" + minx);
            

        }
        static void PrintL(int[] array) {
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine(array[i]);
            }
        }
        static void SecondPart(int[] array) {
            int sums = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0) {
                    for (int j = i+1; j< array.Length; j++) {
                        sums += Math.Abs(array[j]);
                    }
                    break;
                }
            }
            
            Console.WriteLine("Сумма модулей элементов массива после первого нуля "+ sums);
        }
        //Преобразовать массив таким образом, чтобы в первой его половине распологались
        //элементы, стоявшие в четных позиция, а во второй половине  - элементы,
        //стоявшие на нечётных позициях
        static void ThirdPart(int[] array) {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result[i / 2] = array[i];
                }
                else
                {
                    result[array.Length / 2 + ((i - 1) / 2)] = array[i];
                }
            }
                foreach(int num in result)
                {
                    Console.WriteLine(num + "");
                }
        }
    }
}
