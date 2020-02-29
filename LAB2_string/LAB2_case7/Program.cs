using System;

namespace LAB2_case7
{
    class Intro
    {
        public String LabName = "Лабораторная работа №1: Строки";
        public String Author = "Даниил Огнев";
        public String Group = "МГ-196";
        public String Task = "Задание 7. Написать программу, которая осуществляет перевод из дробного неотрицательного DEC в HEX строку.";
        public String TestCase = "[INFO] ТЕСТ. Исходное число 31,1315. Ожидаемый результат: 1F,21AA";
        public String TestString = "31,1315";

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
            int a = (int) float.Parse(Input);
            int b = 0;
            float c = (float) (float.Parse(Input) - a);
            int d = 0;
            string OutputA = "";
            string OutputB = "";
            while (a != 0)
            {
                b = a % 16;
                switch (b)
                {
                    case 10:
                        OutputA = "A" + OutputA;
                        break;
                    case 11:
                        OutputA = "B" + OutputA;
                        break;
                    case 12:
                        OutputA = "C" + OutputA;
                        break;
                    case 13:
                        OutputA = "D" + OutputA;
                        break;
                    case 14:
                        OutputA = "E" + OutputA;
                        break;
                    case 15:
                        OutputA = "F" + OutputA;
                        break;
                    default:
                        OutputA = b.ToString() + OutputA;
                        break;
                }
                a /= 16;
            }
            while (c != 0)
            {
                d = (int)(16 * c);
                Console.WriteLine("123 :" + d);
                c = c * 16 - d;
                Console.WriteLine(c);
                switch (d)
                {
                    case 10:
                        OutputB = OutputB + "A";
                        break;
                    case 11:
                        OutputB = OutputB + "B";
                        break;
                    case 12:
                        OutputB = OutputB + "C";
                        break;
                    case 13:
                        OutputB = OutputB + "D";
                        break;
                    case 14:
                        OutputB = OutputA + "E";
                        break;
                    case 15:
                        OutputB = OutputB + "F";
                        break;
                    default:
                        OutputB = OutputB + d.ToString() ;
                        break;
                }
            }
            return OutputA+","+OutputB;
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

                    Console.WriteLine("[MAIN]: Введите дробное DEC (разделитель \',\')");
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
