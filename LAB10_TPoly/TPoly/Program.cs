using System;

namespace TPoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[MAIN - Полином]: Забор данных");
            TPoly A = new TPoly(3,2);
            A.Add(4,1);
            A.Add(3,1);
            TPoly B = new TPoly(4,1);
            B.Add(6,2);
            B.Add(8,3);
            B.Add(3,0);
            TPoly C = new TPoly(); 
            TPoly D = new TPoly(2,3);
            D.Add(6, 2);
            TPoly E = new TPoly(3,3);
            E.Add(7, 2);
            Console.WriteLine("[MAIN - Полином]:" + A.PolyToString());
            Console.WriteLine("[MAIN - Полином]:" + B.PolyToString());
            Console.WriteLine("[MAIN - Полином]: Функция степень");
            Console.WriteLine("[MAIN - Полином]:" + A.ReturnDegree());
            Console.WriteLine("[MAIN - Полином]: Функция коэффициент");
            Console.WriteLine("[MAIN - Полином]:" + A.ReturnCoeffWithDegree(2));
            Console.WriteLine("[MAIN - Полином]:" + A.ReturnCoeffWithDegree(4));
            Console.WriteLine("[MAIN - Полином]: Функция сложить");
            Console.WriteLine("[MAIN - Полином]:" + A.PolyToString());
            Console.WriteLine("[MAIN - Полином]:" + B.PolyToString());
            A.Summ(B);
            Console.WriteLine("[MAIN - Полином]:" + A.PolyToString());
            Console.WriteLine("[MAIN - Полином]: Функция умножить");
            Console.WriteLine("[MAIN - Полином]:" + A.PolyToString());
            Console.WriteLine("[MAIN - Полином]:" + B.PolyToString());
            C = A.Mult(B);
            Console.WriteLine("[MAIN - Полином]:" + C.PolyToString());
            Console.WriteLine("[MAIN - Полином]: Функция вычесть");
            Console.WriteLine("[MAIN - Полином]:" + D.PolyToString());
            Console.WriteLine("[MAIN - Полином]:" + E.PolyToString()); 
            D.Sub(E);
            Console.WriteLine("[MAIN - Полином]:" + D.PolyToString());
            Console.WriteLine("[MAIN - Полином]: Функция минус(инверсия)");
            Console.WriteLine("[MAIN - Полином]:" + A.PolyToString());
            A.Invert();
            Console.WriteLine("[MAIN - Полином]:" + A.PolyToString());
            Console.WriteLine("[MAIN - Полином]: Функция равно");
            Console.WriteLine("[MAIN - Полином]:" + A.PolyToString());
            Console.WriteLine("[MAIN - Полином]:" + B.PolyToString());
            Console.WriteLine("[MAIN - Полином]:" + A.Equal(A));
            Console.WriteLine("[MAIN - Полином]:" + A.Equal(B));
            Console.WriteLine("[MAIN - Полином]: Функция дифференцировать");
            Console.WriteLine("[MAIN - Полином]:" + A.PolyToString());
            A.FullDiff();
            Console.WriteLine("[MAIN - Полином]:" + A.PolyToString());
            Console.WriteLine("[MAIN - Полином]: Функция вычислить");
            Console.WriteLine("[MAIN - Полином]:" + A.PolyToString());
            Console.WriteLine("[MAIN - Полином]:" + A.Solve(1));
        }
    }
}
