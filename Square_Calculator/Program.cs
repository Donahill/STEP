using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Calculator
{
    class Program
    {
        static void Main()
        {
            string command;
            while (true)
            {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Решение квадратного уравнения");
            //ввод данных
            Console.Write("a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            var c = double.Parse(Console.ReadLine());

            double x1, x2;
            //дискриминант
            var discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("Квадратное уравнение не имеет корней");
            }
            else
            {
                if (discriminant == 0) //квадратное уравнение имеет два одинаковых корня
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                }
                else //уравнение имеет два разных корня
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                }
                //вывод корней уравнения
                Console.WriteLine($"x1 = {x1}; x2 = {x2}");
            }

            Console.WriteLine("Для выхода нажмите x, для продолжения любую другую клавишу...");
            command = Console.ReadLine();
            if (command == "x") break;
            Console.ReadKey(true);
            }
        }
    }
}