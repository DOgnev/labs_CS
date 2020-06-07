using System;

namespace LAB6_integer_16
{
    class Intro
    {
        public String LabName = "Лабораторная работа №6: Редактор р-ичных действительных чисел";
        public String Author = "Даниил Огнев";
        public String Group = "МГ-196";
        public String Task = "Задание. Разработать класс Editor для редактирования 16-ричных чисел.";

        public void Info()
        {
            Console.WriteLine("[INFO]: Название: " + LabName);
            Console.WriteLine("[INFO]: Задание: " + Task);
            Console.WriteLine("[INFO]: Выполнил: " + Author);
            Console.WriteLine("[INFO]: Группа: " + Group);
        }
    }

    class Editor
    {
        static String delim = ".", signe = "-", zero = "0.0"; 
        static String Number = Editor.zero;
        static void AddDigit(ref String Number, int Digit)
        {
            switch (Digit)
            {
                case 10:
                    {
                        Number = Number + "A";
                        Console.WriteLine("[Editor.AddDigit]: Текущее значение: " + Number);
                        break;
                    }
                case 11:
                    {
                        Number = Number + "B";
                        Console.WriteLine("[Editor.AddDigit]: Текущее значение: " + Number);
                        break;
                    }
                case 12:
                    {
                        Number = Number + "C";
                        Console.WriteLine("[Editor.AddDigit]: Текущее значение: " + Number);
                        break;
                    }
                case 13:
                    {
                        Number = Number + "D";
                        Console.WriteLine("[Editor.AddDigit]: Текущее значение: " + Number);
                        break;
                    }
                case 14:
                    {
                        Number = Number + "E";
                        Console.WriteLine("[Editor.AddDigit]: Текущее значение: " + Number);
                        break;
                    }
                case 15:
                    {
                        Number = Number + "F";
                        Console.WriteLine("[Editor.AddDigit]: Текущее значение: " + Number);
                        break;
                    }
                default:
                    {
                        if (Digit > 0 && Digit < 10)
                        {
                            Number = Number + Digit.ToString();
                            Console.WriteLine("[Editor.AddDigit]: Текущее значение: " + Number);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("[Editor.AddDigit]: Невалидные входные данные, проверьте введенное число");
                            break;
                        }
                    }
            }
        }
        static void AddZero(ref String Number)
        {
            Number += "0";
            Console.WriteLine("[Editor.AddZero]: Текущее значение: " + Number);
        }
        static void BackSpace(ref String Number)
        {
            String Temp = "";
            if (Number == "")
                Console.WriteLine("[Editor.BackSpace]: Невозможно удалить символ, число не определено.");
            else
            {
                for (int i = 0; i < Number.Length - 1; i++)
                {
                    Temp = Temp + Number[i];
                }
                Number = Temp;
                Console.WriteLine("[Editor.BackSpace]: Текущее значение: " + Number);
            }

        }
        static void AddSigne(ref String Number)
        {
            if (Number[0].ToString() == Editor.signe)
            {
                Number = Number.Substring(1);
                Console.WriteLine("[Editor.AddSigne]: Текущее значение: " + Number);
            }
            else
            {
                Number = Editor.signe + Number;
                Console.WriteLine("[Editor.AddSigne]: Текущее значение: " + Number);
            }
        }
        static void Clear(ref String Number)
        {
            Number = Editor.zero;
            Console.WriteLine("[Editor.Clear]: Текущее значение: " + Number);
        }
        static void AddDelim(ref String Number)
        {
            if (Number.Contains(Editor.delim))            
                Console.WriteLine("[Editor.AddDelim]: Данное число уже имеет разделитель");
            else 
                Number += Editor.delim;
                Console.WriteLine("[Editor.AddDelim]: Текущее значение: " + Number);
        }
        public void DoEdit(int CommandIndex)
        {
            switch (CommandIndex)
            {
                case 1:
                {
                    Console.WriteLine("[Editor.AddDigit]: Введите значение числа от 1 до 15");
                    int Digit = int.Parse(Console.ReadLine());
                    Editor.AddDigit(ref Editor.Number, Digit);
                    Console.WriteLine();
                    break;
                }
                case 2:
                {
                    Editor.AddZero(ref Editor.Number);
                    Console.WriteLine();
                    break;
                }
                case 3:
                {
                    Editor.BackSpace(ref Editor.Number);
                    Console.WriteLine();
                    break;
                }
                case 4:
                {
                    Editor.AddSigne(ref Editor.Number);
                    Console.WriteLine();
                    break;
                }
                case 5:
                {
                    Editor.Clear(ref Editor.Number);
                    Console.WriteLine();
                    break;
                }
                case 6:
                {
                    Editor.AddDelim(ref Editor.Number);
                    Console.WriteLine();
                    break;
                }
                case 0:
                {
                     Console.WriteLine("[Editor.DoEdit]: Информация для вызова функций");
                     Console.WriteLine("[Editor.DoEdit]: 1: AddDigit - Функция добавления цифры от 1 до 15 в конец числа");
                     Console.WriteLine("[Editor.DoEdit]: 2: AddZero - Функция добавления нуля в конец числа");
                     Console.WriteLine("[Editor.DoEdit]: 3: BackSpace - Функция удаления крайней правой цифры числа");
                     Console.WriteLine("[Editor.DoEdit]: 4: AddSigne - Функция удаления/добавления знака \"-\" к числу");
                     Console.WriteLine("[Editor.DoEdit]: 5: Clear - Функция очистки числа, присваивается значение 0.0");
                     Console.WriteLine("[Editor.DoEdit]: 6: AddDelim - Функция добавляет знак резделитель между целой и дробной частью");
                     Console.WriteLine();
                     break;
                    }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Intro Intro = new Intro();
            Editor Editor = new Editor();
            String Input = "";
            Intro.Info();
            while (true)
            {
                Console.WriteLine("[Main]: Вызываю функцию Editor.DoEdit, ожидаю ввод, для дополнительной информации нажмите 0, для выхода введите Exit");
                Input = Console.ReadLine();
                if (Input == "Exit") break;
                Editor.DoEdit(int.Parse(Input));
            }
        }
    }
}