using System;

namespace LAB3_case9
{
    class Intro
    {
        public String LabName = "Лабораторная работа №3: Методы класса";
        public String Author = "Даниил Огнев";
        public String Group = "МГ-196";
        public String Task = "Задание 9. Написать программу, которая возвращает из исходных данных заданный разряд целого числа";
        public String TestCase = "[INFO] ТЕСТ. Исходные данные X1 = 987654321 X2 = 5. Ожидаемый результат: 5";
        public String TestString = "987654321 5";

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
        public int DigitsCounterFunction(String Input)
        {
            Function B = new Function();
            int j = int.Parse(Input.Split(' ')[0]);
            int k = int.Parse(Input.Split(' ')[1]);
            int l = 0;
            while (k != 0)
                {
                if ((j / 10) == 0)
                {
                    return -1;
                }
                else
                {
                    l = j % 10;
                    j = j / 10;
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
