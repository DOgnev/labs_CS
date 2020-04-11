using System;

namespace LAB3_case10
{
    class Intro
    {
        public String LabName = "Лабораторная работа №3: Методы класса";
        public String Author = "Даниил Огнев";
        public String Group = "МГ-196";
        public String Task = "Задание 10. Написать программу, которая возвращает из исходных данных заданный разряд дробной части вещественного числа";
        public String TestCase = "[INFO] ТЕСТ. Исходные данные X1 = 0,123456789 X2 = 5. Ожидаемый результат: 5";
        public String TestString = "0,12345678 5";

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
        public double DigitsCounterFunction(String Input)
        {
            Function B = new Function();
            double j = double.Parse(Input.Split(' ')[0]);
            int k = int.Parse(Input.Split(' ')[1]);
            int le = Input.Split(' ')[0].Split(',')[1].Length;
            j = double.Parse((j - (double)Math.Truncate(j)).ToString("f" + le));
            double l = 0;
            if (j.ToString().Length < k + 2)
            {
                return -1;
            }
            else
            {
                while (k != 0)
                {
                    j = j * 10;
                    l = (double)Math.Truncate(j);
                    j = j - (double)Math.Truncate(j);
                    k--;
                }
            }
            return l;
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
                    Console.WriteLine("[MAIN]: " + A.DigitsCounterFunction(B.TestString));
                    Console.WriteLine("[MAIN]: Нажмите любую клавишу для продолжения");
                    Console.ReadLine();

                }
                else if (C == "2")
                {

                    Console.WriteLine("[MAIN]: Введите значения числа и требуемого знака <X1,X2(integer)(' ' SPACE separator)>");
                    String D = Console.ReadLine();
                    Console.WriteLine("[MAIN]: " + A.DigitsCounterFunction(D));
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