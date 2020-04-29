using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1, n, i = 1, first = 1, element;
            string input;
            bool ok;
            Console.WriteLine("Программа для поиска количества элементов последовательности из n целых чисел, которые кратны первому");
            do
            {
                Console.WriteLine("Введите n");
                input = Console.ReadLine();
                ok = int.TryParse(input, out n);
                if (!ok) Console.WriteLine("Некорректный ввод(не число)");
                else;
                if (n < 0) Console.WriteLine("Некорректный ввод(отрицательное число)");
                else;
            } while (!ok || n < 0);//enter n
            if (n ==0) Console.WriteLine("Пустая последовательность");
            else
            {            
               /* do
                {
                    Console.WriteLine("Введите первый элемент последовательности");
                    input = Console.ReadLine();
                    ok = int.TryParse(input, out first);
                    if (!ok) Console.WriteLine("Некорректный ввод");
                    else if(first == 0) Console.WriteLine("На ноль делить нельзя"); ;
                } while (!ok || first == 0);//enter first
                */
                do
                {
                   
                    do
                    {
                        Console.WriteLine($"Введите элемент последовательности №{i}");
                        input = Console.ReadLine();
                        ok = int.TryParse(input, out element);
                        if (!ok) Console.WriteLine("Некорректный ввод");
                        else if (element == 0 && i == 1) Console.WriteLine("На ноль делить нельзя");
                    } while (!ok || (element == 0 && i == 1));//enter element
                    if (i == 1) first = element;
                    if (element % first == 0) k++;
                    i++;
                } while (i <= n);
                Console.WriteLine($"Количество элементов, кратных первому = {k}");
                Console.WriteLine("(Нуль считается кратным любому числу)");
            }

        }
    }
}
