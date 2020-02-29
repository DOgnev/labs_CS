using System;

namespace LAB2_case8
{
    class Intro
    {
        public String LabName = "Лабораторная работа №1: Строки";
        public String Author = "Даниил Огнев";
        public String Group = "МГ-196";
        public String Task = "Задание 8. Написать программу, которая осуществляет перевод из натурального HEX в строку DEC.";
        public String TestCase = "[INFO] ТЕСТ. Исходное число 1F. Ожидаемый результат: 31";
        public String TestString = "1F";

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
            int b = 0;
            int a = 0;
            for (int i = 0; i < Input.Length; i++)
            {
                int k = Input.Length - i - 1;
                char ch = Input[k];
                switch (ch)
                {
                    case 'A':
                        a = (int) 10;
                        break;
                    case 'B':
                        a = (int) 11;
                        break;
                    case 'C':
                        a = (int) 12;
                        break;
                    case 'D':
                        a = (int) 13;
                        break;
                    case 'E':
                        a = (int) 14;
                        break;
                    case 'F':
                        a = (int) 15;
                        break;
                    default:
                        a = (int) char.GetNumericValue(Input[k]);
                        break;
                }
                b += (int) (a * (Math.Pow(16,(double) i)));
            }
            return b.ToString();
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

                    Console.WriteLine("[MAIN]: Введите натуральное число в HEX");
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