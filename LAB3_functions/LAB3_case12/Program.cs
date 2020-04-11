using System;
using System.Text.RegularExpressions;

namespace LAB3_case12
{
    class Intro
    {
        public String LabName = "Лабораторная работа №3: Методы класса";
        public String Author = "Даниил Огнев";
        public String Group = "МГ-196";
        public String Task = "Задание 11,12. Написать программу, которая возвращает из исходных данных x=N, y=B строку вида x=B, y=N. Метод является функцией не возвращающей значение.";
        public String TestCase = "[INFO] ТЕСТ. Исходные данные X=23,32; Y=-23,32. Ожидаемый результат: X=-23,32; y=23,32";
        public String TestString = "X=23,32; y=-23,32";

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
        public void VariableSwapFunction(String Input)
        {
            Regex regex = new Regex(@"([A-Za-z]=)([-]?[\d]*[,.]{1}[\d]*)");
            MatchCollection matches = regex.Matches(Input);
            Console.WriteLine(matches[0].Groups[1].ToString()+matches[1].Groups[2].ToString()+"; "+matches[1].Groups[1].ToString()+matches[0].Groups[2].ToString());
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
                    Console.WriteLine("[MAIN]: Initiate Function");
                    A.VariableSwapFunction(B.TestString);
                    Console.WriteLine("[MAIN]: Нажмите любую клавишу для продолжения");
                    Console.ReadLine();

                }
                else if (C == "2")
                {

                    Console.WriteLine("[MAIN]: Введите значения числа и требуемого знака в формате \"<VAR1>=<VAR1_VALUE><;><SPACE><VAR2>=<VAR2_VALUE>\"");
                    String D = Console.ReadLine();
                    Console.WriteLine("[MAIN]: Initiate Function");
                    A.VariableSwapFunction(D);
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
