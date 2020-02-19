using System;

namespace LAB1_case5
{

    class Intro
    {
        public String LabName = "Лабораторная работа №1: Одномерные массивы";
        public String Author = "Даниил Огнев";
        public String Group = "МГ-196";
        public String Task = "Задание 5. Разработать приложение, которое находит заданный элемент в массиве и возвращает на экран индекс данного элемента на экран.";
        public String TestCase = "[INFO]: ТЕСТ. Определение 5 элементов массива: 5, 4, 3, 4, 1. Искомое значение 4. Ожидается результат: 2 и 4. Во втором проходе искомое значение 7. Ожидается результат -1.";
        public int[] TestArrayA = { 5, 4, 3, 4, 1 };
        public int[] TestArrayB = { 4, 7 };

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
                    
                    for (int j = 0; j < 2; j++)
                    {
                        int k = 0;
                        for (int i = 0; i < B.TestArrayA.Length; i++)
                        {
                            if (B.TestArrayA[i] == B.TestArrayB[j])
                            {
                                Console.WriteLine("[MAIN]: Искомое значение: " + B.TestArrayB[j] + ". Позиция: " + i);
                                k++;
                            }
                         
                        }
                        if (k == 0)
                        {
                            Console.WriteLine("[MAIN]: Искомое значение: " + B.TestArrayB[j] + ". Позиция: -1");
                        }
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
                    Console.WriteLine("[MAIN]: Ожидается ввод искомого числа.");
                    int k = 0, l = 0;
                    l = int.Parse(Console.ReadLine());
                    Console.WriteLine("[MAIN]: Введено значение: " + l);
                    Console.WriteLine();
                    for (int i = 0; i < A.Length; i++)
                    {
                            if (A[i] == l)
                            {
                                Console.WriteLine("[MAIN]: Искомое значение: " + l + ". Позиция: " + i);
                                k++;
                            }

                    }
                    if (k == 0)
                    {
                            Console.WriteLine("[MAIN]: Искомое значение: " + l + ". Позиция: -1");
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
                    Console.WriteLine("[MAIN]: Нажмите любую клавишу для продолжения");
                    Console.ReadLine();
                }

            }
        }
    }
}
