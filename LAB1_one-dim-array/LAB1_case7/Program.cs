using System;

namespace LAB1_case7
{

    class Intro
    {
        public String LabName = "Лабораторная работа №1: Одномерные массивы";
        public String Author = "Даниил Огнев";
        public String Group = "МГ-196";
        public String Task = "Задание 7. Разработать приложение, которое меняет элементы массива местами зеркально.";
        public String TestCase = "[INFO]: ТЕСТ. Определение 5 элементов массива: 5, 4, 3, 2, 1. Ожидается результат: 1, 2, 3, 4, 5";
        public int[] TestArrayA = { 5, 4, 3, 4, 1 };

        public void Info()
        {
            Console.WriteLine("[INFO]: Название: " + LabName);
            Console.WriteLine("[INFO]: Задание: " + Task);
            Console.WriteLine("[INFO]: Выполнил: " + Author);
            Console.WriteLine("[INFO]: Группа: " + Group);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Intro B = new Intro();
            int[] A = new int[5];
            string C = "";
            B.Info();
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("[MAIN]: Для выхода из программы \"Exit\"");
                Console.WriteLine("[MAIN]: Для вызова тестового задания, нажмите \"1\"");
                Console.WriteLine("[MAIN]: Для вызова задания с собственными параметрами нажмите \"2\"");
                C = Console.ReadLine();

                if (C == "1")
                {
                    Console.WriteLine(B.TestCase);

                    int k = 0;
                    for (int i = 0; i < B.TestArrayA.Length/2; i++)
                    {
                        k = B.TestArrayA[i];
                        B.TestArrayA[i] = B.TestArrayA[B.TestArrayA.Length - i - 1];
                        B.TestArrayA[B.TestArrayA.Length - i - 1] = k;
                        k = 0;
                    }
                    Console.WriteLine("[MAIN]: Полученный массив имеет вид:");
                    for (int i = 0; i < B.TestArrayA.Length; i++)
                    {
                        Console.WriteLine("[MAIN]: #" + i +": "+ B.TestArrayA[i]);
                    }
                    Console.WriteLine("[MAIN]: Нажмите любую клавишу для продолжения");
                    Console.ReadLine();

                }
                else if (C == "2")
                {
                    for (int i = 0; i < A.Length; i++)
                    {
                        Console.WriteLine("[MAIN]: Ожидается ввод элемента массива А.");
                        A[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("[MAIN]: Введено значение: " + A[i]);
                        Console.WriteLine();
                    }

                    int k = 0;
                    for (int i = 0; i < A.Length / 2; i++)
                    {
                        k = A[i];
                        A[i] = A[A.Length - i - 1];
                        A[A.Length - i - 1] = k;
                        k = 0;
                    }
                    Console.WriteLine("[MAIN]: Полученный массив имеет вид:");
                    for (int i = 0; i < A.Length; i++)
                    {
                        Console.WriteLine("[MAIN]: #" + i + ": " + A[i]);
                    }
                    Console.WriteLine("[MAIN]: Нажмите любую клавишу для продолжения");
                    Console.ReadLine();

                }
                else if (C == "Exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("[MAIN]: Неверный формат, попробуйте снова");
                    Console.WriteLine();
                }

            }
        }
    }
}
