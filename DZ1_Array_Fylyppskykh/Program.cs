using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1_Array_Fylyppskykh
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] someArray = new int[10];
            Random Rand = new Random();

            for (int x=0; x<someArray.Length;x++)
            {
                someArray[x] = Rand.Next(20)-10;
                Console.WriteLine("Значение элемента массива " + x + "=" + someArray[x]);
            }
            Console.ReadKey();

            ///////////////////////////////////////////////////////////////
            Console.WriteLine("Проверка массива на нули.");
            Console.WriteLine("Сжимаем массив, устанавливая в освободившиеся справа ячейки '-1'.");

            int[] anotherArray = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            int y=0;
            for(int x=0;x<someArray.Length;x++)
            {
                if (someArray[x] != 0)
                    {
                    anotherArray[y] = someArray[x];
                    y++;
                    }
            }
            someArray = anotherArray;
            anotherArray = null;
            for (int x=0;x<someArray.Length;x++)
            {
                Console.WriteLine("Значение элемента массива " + x + "=" + someArray[x]);
            }
            Console.ReadKey();
            ////////////////////////////////////////////////////////

            Console.WriteLine("Переносим отрицательные элементы вперед массива.");
            Array.Sort(someArray, (a, b) => Math.Sign(a) - Math.Sign(b));
 
            for (int x=0;x<someArray.Length;x++)
            {
                Console.WriteLine("Значение элемента массива " + x + "=" + someArray[x]);
            }

            Console.ReadKey();

            ///////////////////////////////////////////////////////////
            
            Console.WriteLine("Введите число: ");
            Console.Write("test input number= ");
            var test_input = double.Parse(Console.ReadLine());
            int test_counter = 0;
            for (int x=0;x<someArray.Length;x++)
            {
                if (someArray[x]==test_input)
                {
                    test_counter++;
                }
            }
            Console.WriteLine("Введённое число присутствует в массиве {0} {1}", test_counter, " раз");
            Console.ReadKey();
        }
    }
}
