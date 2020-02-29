using System;

namespace LAB2_case2
{
    class Intro
    {
        public String LabName = "Лабораторная работа №1: Строки";
        public String Author = "Даниил Огнев";
        public String Group = "МГ-196";
        public String Task = "Задание 2. Написать программу, которая осуществляет циклический сдвиг литер в строке Str влево на одну позицию.";
        public String TestCase = "[INFO] ТЕСТ. Исходная строка QWERTY. Ожидается результат WERTYQ";
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
        public String Shifting(string Input)
        {
             string a = Input.Substring(0, 1);
            string b = Input.Substring(1, Input.Length - 1);
            return b + a;
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
                    Console.WriteLine("[MAIN]:" + A.Shifting(B.TestString));
                    Console.WriteLine("[MAIN]: Нажмите любую клавишу для продолжения");
                    Console.ReadLine();

                }
                else if (C == "2")
                {

                    Console.WriteLine("[MAIN]: Введите строку для сдвига.");
                    String D = Console.ReadLine();
                    Console.WriteLine("[MAIN]:" + A.Shifting(D));
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
