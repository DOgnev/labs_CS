using System;

namespace LAB4_StaticFunction
{
    class Intro
    {
        public String LabName = "Лабораторная работа №4: Статический класс";
        public String Author = "Даниил Огнев";
        public String Group = "МГ-196";
        public String Task = "Задание. Реализовать статический класс ClassFunction, который реализует определенные ниже методы: 1) Смена значений переменных без дополнительных переменных 2) Поиск максимального значения из 2-х вещественных переменных 3) Упорядочивание значений переменных по возрастанию. 4) Поиск максимального из трех переменных  5) Поиск максимального и минимального из трех переменных. 6) Упорядочивание значений переменных по убыванию.";
        public String TestCase1 = "[INFO] ТЕСТ1. Исходные данные 23,32 -23,32. Ожидаемый результат: -23,32; 23,32";
        public String TestString1 = "23,32 -23,32";
        public String TestCase2 = "[INFO] ТЕСТ2. Исходные данные 23,32 -23,32. Ожидаемый результат: 23,32";
        public String TestString2 = "23,32 -23,32";
        public String TestCase3 = "[INFO] ТЕСТ3. Исходные данные 23,32 -23,32. Ожидаемый результат: -23,32; 23,32";
        public String TestString3 = "23,32 -23,32";
        public String TestCase4 = "[INFO] ТЕСТ4. Исходные данные 23,32 -23,32 32,23 Ожидаемый результат: 32,23";
        public String TestString4 = "32,23 23,32 -23,32";
        public String TestCase5 = "[INFO] ТЕСТ5. Исходные данные 23,32 -23,32 32,23 Ожидаемый результат: {-23,32; 32,32}";
        public String TestString5 = "32,23 23,32 -23,32";
        public String TestCase6 = "[INFO] ТЕСТ6. Исходные данные 23,32 -23,32 32,23 Ожидаемый результат:  32,23 23,32 -23,32";
        public String TestString6 = "32,23 23,32 -23,32";

        public void Info()
        {
            Console.WriteLine("[INFO]: Название: " + LabName);
            Console.WriteLine("[INFO]: Задание: " + Task);
            Console.WriteLine("[INFO]: Выполнил: " + Author);
            Console.WriteLine("[INFO]: Группа: " + Group);
        }
    }
    class ClassFunction
    {
        public static void Swap(ref double x, ref double y)
        {
            double swap;
            swap = x;
            x = y;
            y = swap;
        }
        public static double SearchMax(double x, double y)
        {
            if (x > y)
            {
                return x;
            }
            return y;
        }
        public static double SearchMin(double x, double y)
        {
            if (x < y)
            {
                return x;
            }
            return y;
        }
        public static void UpstairsSort(ref double x, ref double y)
        {
            if (x > y)
            {
                ClassFunction.Swap(ref x, ref y);
            }
        }
        public static double SearchMaxThree(double x, double y, double z)
        {
            double t;
            t = ClassFunction.SearchMax(x, y);
            return ClassFunction.SearchMax(t, z);           
        }
        public static double SearchMinThree(double x, double y, double z)
        {
            double t;
            t = ClassFunction.SearchMin(x, y);
            return ClassFunction.SearchMin(t, z);
        }
        public static double[] SearchMaxMinThree(double x, double y, double z)
        {
            double[] result = new double[2];
            result[0] = ClassFunction.SearchMinThree(x, y, z);
            result[1] = ClassFunction.SearchMaxThree(x, y, z);
            return result;
        }
        public static void DownStairsSort(ref double x,ref double y,ref double z)
        {
            if (x < y)
            {
                ClassFunction.Swap(ref x, ref y);
            }
            if (y < z)
            {
                ClassFunction.Swap(ref y, ref z);
            }
            if (x < y)
            {
                ClassFunction.Swap(ref x, ref y);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
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
                C = Console.ReadLine();

                if (C == "1")
                {
                    //Вызов тест кейса для 1 задания
                    Console.WriteLine(B.TestCase1);
                    Console.WriteLine();
                    Console.WriteLine("[MAIN]:  Инициализация функции Swap");
                    double a, b, c;
                    a = double.Parse(B.TestString1.Split(' ')[0]);
                    b = double.Parse(B.TestString1.Split(' ')[1]);
                    ClassFunction.Swap(ref a, ref b);
                    Console.WriteLine("[MAIN]: a=" + a +"; b="+ b);
                    Console.WriteLine();

                    //Вызов тест кейса для 2 задания
                    Console.WriteLine(B.TestCase2);
                    Console.WriteLine();
                    Console.WriteLine("[MAIN]:  Инициализация функции SearchMax");
                    Console.WriteLine("[MAIN]: Max= " + ClassFunction.SearchMax(double.Parse(B.TestString1.Split(' ')[0]), double.Parse(B.TestString1.Split(' ')[1])));
                    Console.WriteLine();

                    //Вызов тест кейса для 3 задания
                    Console.WriteLine(B.TestCase3);
                    Console.WriteLine();
                    Console.WriteLine("[MAIN]: Initiate UpstairsSort Function");
                    a = double.Parse(B.TestString3.Split(' ')[0]);
                    b = double.Parse(B.TestString3.Split(' ')[1]);
                    ClassFunction.UpstairsSort(ref a, ref b);
                    Console.WriteLine("[MAIN]: Sort result: " + a + " " + b);
                    Console.WriteLine();

                    //Вызов тест кейса для 4 задания
                    Console.WriteLine(B.TestCase4);
                    Console.WriteLine();
                    Console.WriteLine("[MAIN]:  Инициализация функции SearchMaxThree");
                    Console.WriteLine("[MAIN]: Max= " + ClassFunction.SearchMaxThree(double.Parse(B.TestString4.Split(' ')[0]), double.Parse(B.TestString4.Split(' ')[1]), double.Parse(B.TestString4.Split(' ')[2])));
                    Console.WriteLine();

                    //Вызов тест кейса для 5 задания
                    Console.WriteLine(B.TestCase5);
                    Console.WriteLine();
                    Console.WriteLine("[MAIN]:  Инициализация функции SearchMaxMinThree");
                    Console.WriteLine("[MAIN]: Min= " + ClassFunction.SearchMaxMinThree(double.Parse(B.TestString5.Split(' ')[0]), double.Parse(B.TestString5.Split(' ')[1]), double.Parse(B.TestString5.Split(' ')[2]))[0] + " Max= "+ ClassFunction.SearchMaxMinThree(double.Parse(B.TestString5.Split(' ')[0]), double.Parse(B.TestString5.Split(' ')[1]), double.Parse(B.TestString5.Split(' ')[2]))[1]);
                    Console.WriteLine();

                    //Вызов тест кейса для 6 задания
                    Console.WriteLine(B.TestCase6);
                    Console.WriteLine();
                    Console.WriteLine("[MAIN]: Инициализация функции DownStairsSort");
                    a = double.Parse(B.TestString6.Split(' ')[0]);
                    b = double.Parse(B.TestString6.Split(' ')[1]);
                    c = double.Parse(B.TestString6.Split(' ')[2]);
                    ClassFunction.DownStairsSort(ref a, ref b, ref c);
                    Console.WriteLine("[MAIN]: Sort result: " + a + " " + b + " " + c);
                    Console.WriteLine();
                    Console.WriteLine("[MAIN]: Нажмите любую клавишу для продолжения");
                    Console.ReadLine();

                }
                else if (C == "2")
                {
                    Boolean check = true;
                    while (check == true)
                    {
                        Console.WriteLine("[MAIN]: Выберите используемую функцию для проверки цифрами 1-6, для вызова подсказки введите INFO");
                        String D = Console.ReadLine();
                        switch (D)
                        {
                           case "1": 
                                {
                                    Console.WriteLine("[MAIN]: Выбрана функция Swap, введите строку со значениями в формате \"<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 1><'SPACE'><ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 2>\"");
                                    double a, b;
                                    String Input = Console.ReadLine();
                                    a = double.Parse(Input.Split(' ')[0]);
                                    b = double.Parse(Input.Split(' ')[1]);
                                    ClassFunction.Swap(ref a, ref b);
                                    Console.WriteLine("[MAIN]: Swap result: (" + double.Parse(Input.Split(' ')[0]) + ";" + double.Parse(Input.Split(' ')[1]) + ") Now: ("+ a +";" + b +")");
                                    Console.WriteLine();
                                    break;
                                }
                            case "2":
                                {
                                    Console.WriteLine("[MAIN]: Выбрана функция SearchMax, введите строку со значениями в формате \"<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 1><'SPACE'><ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 2>\"");
                                    String Input = Console.ReadLine();
                                    Console.WriteLine("[MAIN]: SearchMax result: " + ClassFunction.SearchMax(double.Parse(Input.Split(' ')[0]),double.Parse(Input.Split(' ')[1])));
                                    Console.WriteLine();
                                    break;
                                }
                            case "3":
                                {
                                    Console.WriteLine("[MAIN]: Выбрана функция UpstairsSort, введите строку со значениями в формате \"<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 1><'SPACE'><ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 2>\"");
                                    double a, b;
                                    String Input = Console.ReadLine();
                                    a = double.Parse(Input.Split(' ')[0]);
                                    b = double.Parse(Input.Split(' ')[1]);
                                    ClassFunction.Swap(ref a, ref b);
                                    Console.WriteLine("[MAIN]: UpstairsSort result: (" + double.Parse(Input.Split(' ')[0]) + ";" + double.Parse(Input.Split(' ')[1]) + ") Now: (" + a + ";" + b + ")");
                                    Console.WriteLine();
                                    break;
                                }
                            case "4":
                                {
                                    Console.WriteLine("[MAIN]: Выбрана функция SearchMaxThree, введите строку со значениями в формате \"<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 1><'SPACE'><ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 2><'SPACE'><ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 3>\"");
                                    String Input = Console.ReadLine();
                                    Console.WriteLine("[MAIN]: SearchMaxThree result: " + ClassFunction.SearchMaxThree(double.Parse(Input.Split(' ')[0]), double.Parse(Input.Split(' ')[1]), double.Parse(Input.Split(' ')[2])));
                                    Console.WriteLine();
                                    break;
                                }
                            case "5":
                                {
                                    Console.WriteLine("[MAIN]: Выбрана функция SearchMaxMinThree, введите строку со значениями в формате \"<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 1><'SPACE'><ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 2><'SPACE'><ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 3>\"");
                                    String Input = Console.ReadLine();
                                    Console.WriteLine("[MAIN]: SearchMaxMinThree result: Min: " + ClassFunction.SearchMaxMinThree(double.Parse(Input.Split(' ')[0]), double.Parse(Input.Split(' ')[1]), double.Parse(Input.Split(' ')[2]))[0] + " Max:" + ClassFunction.SearchMaxMinThree(double.Parse(Input.Split(' ')[0]), double.Parse(Input.Split(' ')[1]), double.Parse(Input.Split(' ')[2]))[1]);
                                    Console.WriteLine();
                                    break;
                                }
                            case "6":
                                {
                                    Console.WriteLine("[MAIN]: Выбрана функция DownStairsSort, введите строку со значениями в формате \"<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 1><'SPACE'><ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 2><'SPACE'><ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 3>\"");
                                    double a, b, c;
                                    String Input = Console.ReadLine();
                                    a = double.Parse(Input.Split(' ')[0]);
                                    b = double.Parse(Input.Split(' ')[1]);
                                    c = double.Parse(Input.Split(' ')[2]);
                                    ClassFunction.DownStairsSort(ref a, ref b, ref c);
                                    Console.WriteLine("[MAIN]: DownStairsSort result: (" + double.Parse(Input.Split(' ')[0]) + ";" + double.Parse(Input.Split(' ')[1]) + ";" + double.Parse(Input.Split(' ')[2]) + ") Now: (" + a + ";" + b + ";" + c + ")");
                                    Console.WriteLine();
                                    break;
                                }
                            case "INFO":
                                {
                                    Console.WriteLine("[MAIN]: Для вызова функций воспользуйтесь клавишами с цифрами от 1 до 6");
                                    Console.WriteLine("[MAIN]: 1: Вызов функции смены значений двух переменных");
                                    Console.WriteLine("[MAIN]: 2: Вызов функции нахождения наибольшего из двух чисел");
                                    Console.WriteLine("[MAIN]: 3: Вызов функции упорядочивания по возрастанию для двух чисел");
                                    Console.WriteLine("[MAIN]: 4: Вызов функции нахождения наибольшего из трех чисел");
                                    Console.WriteLine("[MAIN]: 5: Вызов функции нахождения наибольшего и наименьшего из трех чисел");
                                    Console.WriteLine("[MAIN]: 6: Вызов функции упорядочивания по убыванию для трех чисел");
                                    Console.WriteLine("[MAIN]: Для завершения выполнения пункта введите EXIT");
                                    Console.WriteLine("[MAIN]: Нажмите любую клавишу для продолжения");
                                    Console.ReadLine();
                                    break;
                                }
                            case "EXIT":
                                {
                                    check = false;
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("[MAIN]: Введены невалидные данные, проверьте ввод или вызовите справку командой INFO, для выхода введите EXIT");
                                    Console.WriteLine("[MAIN]: Нажмите любую клавишу для продолжения");
                                    Console.ReadLine();
                                    break;
                                }

                        }
                    }
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