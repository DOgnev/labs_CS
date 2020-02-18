using System;

namespace LAB1_case2
{
    class Intro
    {
        public String LabName = "Лабораторная работа №1: Одномерные массивы";
        public String Author = "Даниил Огнев";
        public String Group = "МГ-196";
        public String Task = "Задание 2. Разработать приложение, которое обеспечивает скалярное произведение массивов А и Б";
        public String TestCase = "[INFO] ТЕСТ. Определение 5 элементов А и Б массивов: 1, 2, 3, 4, 5. Ожидается результат: 55.";
        public int[] TestArrayA = { 1, 2, 3, 4, 5 };
        public int[] TestArrayB = { 1, 2, 3, 4, 5 };

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
            int summ = 0;
            int[] A = new int[5];
            int[] D = new int[5];
            string C = "";
            B.Info();
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("[MAIN]: Для выхода из программы \"Exit\"");
                Console.WriteLine("[MAIN]: Для вызова тестового задания, нажмите \"1\"");
                Console.WriteLine("[MAIN]: Для вызова задания с собственными параметрами нажмите \"2\"");
                summ = 0;
                C = Console.ReadLine();

                if (C == "1")
                {
                    Console.WriteLine(B.TestCase);
                    for (int i = 0; i < B.TestArrayA.Length; i++)
                    {
                        summ = summ + B.TestArrayA[i] * B.TestArrayB[i];
                    }

                    Console.WriteLine("[MAIN]: Скалярная сумма:" + summ);
                    Console.WriteLine("[MAIN]: Нажмите любую клавишу для продолжения");
                    Console.ReadLine();

                }
                else if (C == "2")
                {
                    for (int i = 0; i < A.Length; i++)
                    {
                        Console.WriteLine("[MAIN]: Ожидается ввод элемента массива А.");
                        A[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("[MAIN]: Ожидается ввод элемента массива Б.");
                        D[i] = int.Parse(Console.ReadLine());
                        summ = summ + A[i] * D[i];
                        Console.WriteLine("[MAIN]: Введено значение: " + A[i]);
                        Console.WriteLine("[MAIN]: Введено значение: " + D[i]);
                        Console.WriteLine();

                    }

                    Console.WriteLine("[MAIN]: Скалярная сумма:" + summ);
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
                    Console.WriteLine("[MAIN]: Нажмите любую клавишу для продолжения");
                    Console.ReadLine();
                }

            }
        }
    }
}
