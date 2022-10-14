using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите два числа и код операции");
                Console.WriteLine(" 0 - сложение \n 1- вычитание \n 2- умножение \n 3 - деление");
                Console.WriteLine("Введите первое число");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите код операции");
                int o = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ваш выбор : {0}", o);
                if (o < 0 || o > 3)
                {
                    Console.WriteLine("Такого кода операции не сущестует");
                }
                else
                {
                    switch (o)
                    {
                        case 0:
                            Console.WriteLine("Ответ :");
                            Console.WriteLine(a + b);
                            break;
                        case 1:
                            Console.WriteLine("Ответ :");
                            Console.WriteLine(a - b);
                            break;
                        case 2:
                            Console.WriteLine("Ответ :");
                            Console.WriteLine(a * b);
                            break;
                        case 3:
                            Console.WriteLine("Ответ :");
                            Console.WriteLine(a / b);
                            break;

                    }
                }
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }

            Console.ReadKey();
        }
    }
}
