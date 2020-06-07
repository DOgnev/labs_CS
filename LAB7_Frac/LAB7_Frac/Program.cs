using System;

namespace LAB7_Frac
{
    class Programm
    {
        static void Main(string[] args)
        {
            Frac a = new Frac(1, 2);
            Console.WriteLine("[MAIN]: Тест функции копирования А в В");
            Frac b = a.Copy();
            Console.WriteLine("[MAIN]: Результат " + b.Frac_);
            Console.WriteLine("[MAIN]: Тест присвоения для А числителя и знаменателя: ч:3, з:4 и вывода различными способами");
            a.Num = 3;
            a.Den = 4;
            Console.WriteLine("[MAIN]: Результат " + a.Frac_);
            Console.WriteLine("[MAIN]: Результат числитель(номер)" + a.Num);
            Console.WriteLine("[MAIN]: Результат числитель(строка)" + a.Num_);
            Console.WriteLine("[MAIN]: Результат знаменатель(номер)" + a.Den);
            Console.WriteLine("[MAIN]: Результат знаменатель(строка)" + a.Den_);
            Console.WriteLine("[MAIN]: Результат числитель(функция)" + a.GetNum());
            Console.WriteLine("[MAIN]: Результат знаменатель(функция)" + a.GetDenom());
            Console.WriteLine("[MAIN]: Тест функции сложения А и В");
            Frac c = a.Add(b);
            Console.WriteLine("[MAIN]: Результат " + c.Frac_);
            Console.WriteLine("[MAIN]: Тест функции вычитания A и B");
            c = a.Sub(b);
            Console.WriteLine("[MAIN]: Результат " + c.Frac_);
            Console.WriteLine("[MAIN]: Тест функции вычитания В и А");
            c = b.Sub(a);
            Console.WriteLine("[MAIN]: Результат " + c.Frac_);
            Console.WriteLine("[MAIN]: Тест функции умножения А и В");
            c = a.Mul(b);
            Console.WriteLine("[MAIN]: Результат " + c.Frac_);
            Console.WriteLine("[MAIN]: Тест функции деления А и В");
            c = a.Dvd(b);
            Console.WriteLine("[MAIN]: Результат " + c.Frac_);
            Console.WriteLine("[MAIN]: Тест функции возведения в квадрат А");
            c = a.Sqr();
            Console.WriteLine("[MAIN]: Результат " + c.Frac_);
            Console.WriteLine("[MAIN]: Тест функции обратная дробь");
            c = a.Rev();
            Console.WriteLine("[MAIN]: Результат " + c.Frac_);
            Console.WriteLine("[MAIN]: Тест функции отрицания");
            c = a.Minus();
            Console.WriteLine("[MAIN]: Результат " + c.Frac_);
            Console.WriteLine("[MAIN]: Тест функции равенства А и Б");
            Console.WriteLine("[MAIN]: Результат " + Frac.Equals(a,b));
            Console.WriteLine("[MAIN]: Тест функции равенства А и А");
            Console.WriteLine("[MAIN]: Результат " + Frac.Equals(a, a));
            Console.WriteLine("[MAIN]: Тест функции сравнения (A и B)");
            Console.WriteLine("[MAIN]: Результат " + a.Greater(b));
            Console.WriteLine("[MAIN]: Тест функции сравнения (В и А)");
            Console.WriteLine("[MAIN]: Результат " + b.Greater(a));
            Console.WriteLine();
        }
    }
}