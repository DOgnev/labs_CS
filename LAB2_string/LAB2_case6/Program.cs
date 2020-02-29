using System;

namespace LAB2_case6
{
    class Intro
    {
        public String LabName = "Лабораторная работа №1: Строки";
        public String Author = "Даниил Огнев";
        public String Group = "МГ-196";
        public String Task = "Задание 6. Написать программу, которая осуществляет перевод из натурального DEC в HEX строку.";
        public String TestCase = "[INFO] ТЕСТ. Исходное число 31. Ожидаемый результат: 1F";
        public String TestString = "31";

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
        public String Calculate(String Input)
        {
            int a = int.Parse(Input);
            int b = 0;
            string Output = "";
            while (a != 0)
            {
                b = a % 16;
                switch (b)
                    {
                    case 10:
                        Output = "A" + Output;
                        break;
                    case 11:
                        Output = "B" + Output;
                        break;
                    case 12:
                        Output = "C" + Output;
                        break;
                    case 13:
                        Output = "D" + Output;
                        break;
                    case 14:
                        Output = "E" + Output;
                        break;
                    case 15:
                        Output = "F" + Output;
                        break;
                    default:
                        Output = b.ToString() + Output;
                        break;
                }
                a /= 16;
            }
            return Output;
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
                    Console.WriteLine("[MAIN]: " + A.Calculate(B.TestString));
                    Console.WriteLine("[MAIN]: Нажмите любую клавишу для продолжения");
                    Console.ReadLine();

                }
                else if (C == "2")
                {

                    Console.WriteLine("[MAIN]: Введите натуральное DEC");
                    String D = Console.ReadLine();
                    Console.WriteLine("[MAIN]:" + A.Calculate(D));
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
