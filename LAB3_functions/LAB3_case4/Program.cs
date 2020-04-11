﻿using System;

namespace LAB3_case4
{
    class Intro
    {
        public String LabName = "Лабораторная работа №3: Методы класса";
        public String Author = "Даниил Огнев";
        public String Group = "МГ-196";
        public String Task = "Задание 4. Написать программу, которая осуществляет проверку 3 вещественных чисел, если они являются сторонами треугольника возвращает ИСТИНУ.";
        public String TestCase = "[INFO] ТЕСТ1. Исходные данные a = 4 b = 3 c = 2. Ожидаемый результат: True. ТЕСТ2. Исходные данные a = 1 b = 3 c = 1. Ожидаемый результат: False.";
        public String TestString1 = "4 3 2";
        public String TestString2 = "1 3 1";

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
        public Boolean Compare(float a,float b,float c)
        {
            if ((a + b)>c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean Result(String Input)
        {
            Function B = new Function();
            return B.Compare(float.Parse(Input.Split(' ')[0]), float.Parse(Input.Split(' ')[1]), float.Parse(Input.Split(' ')[2])) && B.Compare(float.Parse(Input.Split(' ')[1]), float.Parse(Input.Split(' ')[2]), float.Parse(Input.Split(' ')[0])) && B.Compare(float.Parse(Input.Split(' ')[2]), float.Parse(Input.Split(' ')[0]), float.Parse(Input.Split(' ')[1]));
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
                    Console.WriteLine("[MAIN]: " + A.Result(B.TestString1));
                    Console.WriteLine();
                    Console.WriteLine("[MAIN]: " + A.Result(B.TestString2));
                    Console.WriteLine("[MAIN]: Нажмите любую клавишу для продолжения");
                    Console.ReadLine();

                }
                else if (C == "2")
                {

                    Console.WriteLine("[MAIN]: Введите значения сторон треугольника в формате <a,b,c(float)(' ' SPACE separator)");
                    String D = Console.ReadLine();
                    Console.WriteLine("[MAIN]: " + A.Result(D));
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
