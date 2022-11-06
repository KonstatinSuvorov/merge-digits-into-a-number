using System;
/*
  Пользователь вводит с клавиатуры четыре цифры.
Необходимо создать число, содержащее эти цифры. На-
пример, если с клавиатуры введено 1, 5, 7, 8 тогда нужно
сформировать число 1578.
*/

namespace merge_digits_into_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четыре числа: ");
            string num = Console.ReadLine();
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            string num3 = Console.ReadLine();
            Console.WriteLine(num + num1 + num2 + num3);

            Console.ReadKey();
        }
    }
}
