using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0,i=1, element;
            string input;
            bool ok;
            Console.WriteLine("Программа для вычисления суммы элементов последовательности с четными номерами");
            do
            {
                do
                {
                    Console.WriteLine("Введите элемент последовательности или 0 ");
                    input = Console.ReadLine();
                    ok = int.TryParse(input, out element);
                    if (!ok) Console.WriteLine("Некорректный ввод");
                    else;
                } while (!ok );//enter element
                if (i % 2 == 0) s += element;
                i++;
            } while (element != 0);
            if(i>3) Console.WriteLine($"Сумма элементов с четными номерами = {s}");
            else if(i>2) Console.WriteLine("Нет элементов последовательности с четными номерами");
            else Console.WriteLine("Пустая последовательность");
            
        }
    }
}
