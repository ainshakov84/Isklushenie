using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace калькулятор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            try
            {
                Console.WriteLine("Введите 1 -ую целочисленную переменную");
                 a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите 2 -ую целочисленную переменную");
                 b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции");
                Console.WriteLine("1 - сложение");
                Console.WriteLine("2 - вычитание");
                Console.WriteLine("3 - умножение");
                Console.WriteLine("4 - деление");
                Console.Write("Код операции :");
                c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        d = a + b;
                        break;
                    case 2:
                        d = a - b;
                        break;
                    case 3:
                        d = a * b;
                        break;
                    case 4:
                        d = a / b;
                        break;
                    default:
                        Console.WriteLine("Выбрана не коректная операция");
                        Console.ReadLine();
                        return;
                }
                Console.WriteLine("Результат = {0}", d);
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Ошибка"+ ex.Message);
            }
                        Console.ReadKey();
        }

    }
}



