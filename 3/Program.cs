using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string input;
            bool ok;
            Console.WriteLine("Программа для вычисления n чисел Фибоначчи");
            do
            {
                Console.WriteLine("Введите n");
                input = Console.ReadLine();
                ok = int.TryParse(input, out n);
                if (!ok) Console.WriteLine("Некорректный ввод(не число)");
                else if (n < 0) Console.WriteLine("Некорректный ввод(отрицательное число)");
                else;
            } while (!ok || n < 0);//enter n
            if (n == 0) Console.WriteLine("Пустая последовательность");
            else  Console.Write('1');
            int a, b=0, c=1;
            {
                for(int i =2;i<=n;i++)
                {
                    a = b;
                    b = c;
                    c = a + b;
                    Console.Write($" {c}");
                }
                Console.WriteLine(" ");
            }
           
        }
    }
}
