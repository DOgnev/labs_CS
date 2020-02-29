using System;

namespace LAB2_case9
{
    class Intro
    {
        public String LabName = "Лабораторная работа №1: Строки";
        public String Author = "Даниил Огнев";
        public String Group = "МГ-196";
        public String Task = "Задание 9 и 10. Написать программу, которая осуществляет перевод из дробного HEX в строку DEC.";
        public String TestCase = "[INFO] ТЕСТ. Исходное число 1F,21AA. Ожидаемый результат: 31,1315";
        public String TestString = "1F,21AA";

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
            String [] A = Input.Split(',');
            String[] Output = new string [2];
            int b = 0;
            int a = 0;
            for (int i = 0; i < A[0].Length; i++)
            {
                int k = A[0].Length - i - 1;
                char ch = A[0][k];
                switch (ch)
                {
                    case 'A':
                        a = (int)10;
                        break;
                    case 'B':
                        a = (int)11;
                        break;
                    case 'C':
                        a = (int)12;
                        break;
                    case 'D':
                        a = (int)13;
                        break;
                    case 'E':
                        a = (int)14;
                        break;
                    case 'F':
                        a = (int)15;
                        break;
                    default:
                        a = (int)char.GetNumericValue(A[0][k]);
                        break;
                }
                b += (int)(a * (Math.Pow(16, (double)i)));
            }
            Output[0] = b.ToString();
            float d = 0;
            for (int i = 0; i < A[1].Length; i++)
            {
                char ch = A[1][i];
                switch (ch)
                {
                    case 'A':
                        a = (int)10;
                        break;
                    case 'B':
                        a = (int)11;
                        break;
                    case 'C':
                        a = (int)12;
                        break;
                    case 'D':
                        a = (int)13;
                        break;
                    case 'E':
                        a = (int)14;
                        break;
                    case 'F':
                        a = (int)15;
                        break;
                    default:
                        a = (int)char.GetNumericValue(A[1][i]);
                        break;
                }
                d += (float) (a * (1/(Math.Pow(16,(double)i + 1))));
            }
            Output[1] = d.ToString();
            Output[1] = (Output[1].Split(','))[1];
            return Output[0]+","+Output[1];
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
