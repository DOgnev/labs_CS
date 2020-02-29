using System;

namespace LAB2_case3
{
    class Intro
    {
        public String LabName = "Лабораторная работа №1: Строки";
        public String Author = "Даниил Огнев";
        public String Group = "МГ-196";
        public String Task = "Задание 3. Написать программу, которая осуществляет циклический сдвиг литер в строке Str вправо на заданное количество позиций.";
        public String TestCase = "[INFO] ТЕСТ. Исходная строка QWERTY. Задан сдвиг на 3 позиции. Ожидается результат TYQWER";
        public String TestString = "QWERTY";

        public void Info()
        {
            Console.WriteLine("[INFO]: Название: " + LabName);
            Console.WriteLine("[INFO]: Задание: " + Task);
            Console.WriteLine("[INFO]: Выполнил: " + Author);
            Console.WriteLine("[INFO]: Группа: " + Group);
        }
    }
    class StrFunction
    {
        public String Shifting(string Input, int Shiftcount)
        {
            for (int i = 0; i < Shiftcount; i++)
            {
                string a = Input.Substring(0, Input.Length - 1);
                string b = Input.Substring(Input.Length - 1, 1);
                Input = b + a;
            }
            return Input;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StrFunction A = new StrFunction();
            Intro B = new Intro();
            String C = "";
            B.Info();
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("[MAIN]: Для выхода из программы \"Exit\"");
                Console.WriteLine("[MAIN]: Для вызова тестового задания, нажмите \"1\"");
                Console.WriteLine("[MAIN]: Для вызова задания с собственными параметрами нажмите \"2\"");
                ;
                C = Console.ReadLine();

                if (C == "1")
                {
                    Console.WriteLine(B.TestCase);
                    Console.WriteLine();
                    Console.WriteLine("[MAIN]:" + A.Shifting(B.TestString, 2));
                    Console.WriteLine("[MAIN]: Нажмите любую клавишу для продолжения");
                    Console.ReadLine();

                }
                else if (C == "2")
                {

                    Console.WriteLine("[MAIN]: Введите строку для сдвига.");
                    String D = Console.ReadLine();
                    Console.WriteLine("[MAIN]: Введите величину сдвига.");
                    int a = 0;
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("[MAIN]:" + A.Shifting(D,a));
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