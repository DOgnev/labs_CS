using System;
using System.Collections.Generic;
using System.Text;

namespace LAB8_Matrix
{
    class Programm
    {
        static void Main(string[] args)
        {
            Matrix A = new Matrix(2, 2);
            Matrix B = new Matrix(2, 2);
            Matrix C = new Matrix(2, 2);

            Console.WriteLine("[MAIN]: Заполнение Матриц элементами");
            A.SetElement(0, 0, 1);
            A.SetElement(0, 1, 2);
            A.SetElement(1, 0, 3);
            A.SetElement(1, 1, 4);
            B.SetElement(0, 0, 1);
            B.SetElement(0, 1, 2);
            B.SetElement(1, 0, 3);
            B.SetElement(1, 1, 4);
            C.SetElement(0, 0, 5);
            C.SetElement(0, 1, 5);
            C.SetElement(1, 0, 5);
            C.SetElement(1, 1, 5);
            Console.WriteLine("[MAIN]: Матрица А:");
            A.Show();
            Console.WriteLine("[MAIN]: Матрица B:");
            B.Show();
            Console.WriteLine("[MAIN]: Матрица C:");
            C.Show();
            Console.WriteLine("[MAIN]: Проверка функции сложения");
            A.Add(B);
            A.Show();
            Console.WriteLine("[MAIN]: Проверка функции вычитания");
            A.Sub(B);
            A.Show();
            Console.WriteLine("[MAIN]: Проверка функции умножения");
            A.Mul(C);
            A.Show();
            Console.WriteLine("[MAIN]: Проверка функции Равенства");
            Console.WriteLine("[MAIN]: A и C " + A.Eq(C));
            Console.WriteLine("[MAIN]: B и B " + B.Eq(B));
            Console.WriteLine("[MAIN]: Проверка функции Транспонирования");
            B.Show();
            B.Tran();
            B.Show();
            Console.WriteLine("[MAIN]: Проверка функции Минимальный элемент");
            B.Show();
            Console.WriteLine("[MAIN]: Min " + B.Min());

        }
    }
}
