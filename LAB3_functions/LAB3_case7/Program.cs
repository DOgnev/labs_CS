using System;

namespace LAB3_case7
{
    class Intro
    {
        public String LabName = "Лабораторная работа №3: Методы класса";
        public String Author = "Даниил Огнев";
        public String Group = "МГ-196";
        public String Task = "Задание 7. Написать программу, которая осуществляет расчет объем усеченного конуса.";
        public String TestCase = "[INFO] ТЕСТ. Исходные данные R = 4 r = 3 h = 2. Ожидаемый результат: 77,493";
        public String TestString = "4 3 2";

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

        public float СonoidSquare(String Input)
        {
            return (float) (1.0/3.0) * (float) Math.PI * float.Parse(Input.Split(' ')[2]) * ((float.Parse(Input.Split(' ')[0]) * float.Parse(Input.Split(' ')[1])) + ((float)Math.Pow(float.Parse(Input.Split(' ')[0]), 2)) + ((float)Math.Pow(float.Parse(Input.Split(' ')[1]), 2)));
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
                    Console.WriteLine("[MAIN]: " + A.СonoidSquare(B.TestString));
                    Console.WriteLine("[MAIN]: Нажмите любую клавишу для продолжения");
                    Console.ReadLine();

                }
                else if (C == "2")
                {

                    Console.WriteLine("[MAIN]: Введите значения для усеченного конуса в формате <R,r,h(float)(' ' SPACE separator)>");
                    String D = Console.ReadLine();
                    Console.WriteLine("[MAIN]: " + A.СonoidSquare(D));
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
