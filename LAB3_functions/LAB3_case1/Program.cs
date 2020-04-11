using System;

namespace LAB3_Case1
{
    class Intro
    {
        public String LabName = "Лабораторная работа №3: Методы класса";
        public String Author = "Даниил Огнев";
        public String Group = "МГ-196";
        public String Task = "Задание 1. Написать программу, которая получает через параметры два вещественных значения и возвращает наименьшее из них.";
        public String TestCase = "[INFO] ТЕСТ. Исходные значения А=3.1512515; B=61.612312312. Ожидается результат A=3.1512515";
        public String TestString = "3,1512515 61,612312312";

        public void Info()
        {
            Console.WriteLine("[INFO]: Название: " + LabName);
            Console.WriteLine("[INFO]: Задание: " + Task);
            Console.WriteLine("[INFO]: Выполнил: " + Author);
            Console.WriteLine("[INFO]: Группа: " + Group);
        }
    }
    class Function
    {
        public String Compare(string Input)
        {
            float a = float.Parse(Input.Split(' ')[0]);
            float b = float.Parse(Input.Split(' ')[1]);
            if (a > b)
            {
                return b.ToString();
            }
            else
            {
                return a.ToString();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Function A = new Function();
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
                    Console.WriteLine("[MAIN]: " + A.Compare(B.TestString));
                    Console.WriteLine("[MAIN]: Нажмите любую клавишу для продолжения");
                    Console.ReadLine();

                }
                else if (C == "2")
                {

                    Console.WriteLine("[MAIN]: Введите строку для сравнения в формате <A(float),B(float),' '(SPACE separator)>.");
                    String D = Console.ReadLine();
                    Console.WriteLine("[MAIN]: " + A.Compare(D));
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