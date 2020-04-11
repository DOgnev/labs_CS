using System;

namespace LAB5_vector
{
    class Intro
    {
        public String LabName = "Лабораторная работа №5: Статический вектор";
        public String Author = "Даниил Огнев";
        public String Group = "МГ-196";
        public String Task = "Задание. Реализовать статический класс ClassVector, который реализует определенные ниже методы: 1) Поиск максимального элемента массива 2) Перестановка элементов массива в обратном порядке 3) Сдвиг на 1 влево 4) Сдвиг на N влево 5) Сдвиг на 1 вправо  6) Сдвиг на N вправо 7) Сдвиг на N в заданном направлении";
        public String TestCase1 = "[INFO] ТЕСТ1. Исходные данные 11,1 22,2 -33,3 -44,4 55,55 66,66 77,777 888,88 120,32 0. Ожидаемый результат: 888,88";
        public String TestString1 = "11,1 22,2 -33,3 -44,4 55,55 66,66 77,777 888,88 120,32 0";
        public String TestCase2 = "[INFO] ТЕСТ2. Исходные данные 11,1 22,2 -33,3 -44,4 55,55 66,66 77,777 888,88 120,32 0. Ожидаемый результат: 0 120,32 888,88 77,777 66,66 55,55 -44,4 -33,3 22,2 11,1";
        public String TestString2 = "11,1 22,2 -33,3 -44,4 55,55 66,66 77,777 888,88 120,32 0";
        public String TestCase3 = "[INFO] ТЕСТ3. Исходные данные 11,1 22,2 -33,3 -44,4 55,55 66,66 77,777 888,88 120,32 0. Ожидаемый результат: 22,2 -33,3 -44,4 55,55 66,66 77,777 888,88 120,32 0 11,1";
        public String TestString3 = "11,1 22,2 -33,3 -44,4 55,55 66,66 77,777 888,88 120,32 0";
        public String TestCase4 = "[INFO] ТЕСТ4. Исходные данные 11,1 22,2 -33,3 -44,4 55,55 66,66 77,777 888,88 120,32 0 7 Ожидаемый результат: 888,88 120,32 0 11,1 22,2 -33,3 -44,4 55,55 66,66 77,777";
        public String TestString4 = "11,1 22,2 -33,3 -44,4 55,55 66,66 77,777 888,88 120,32 0 7";
        public String TestCase5 = "[INFO] ТЕСТ5. Исходные данные 11,1 22,2 -33,3 -44,4 55,55 66,66 77,777 888,88 120,32 0 Ожидаемый результат: 0 11,1 22,2 -33,3 -44,4 55,55 66,66 77,777 888,88 120,32";
        public String TestString5 = "11,1 22,2 -33,3 -44,4 55,55 66,66 77,777 888,88 120,32 0";
        public String TestCase6 = "[INFO] ТЕСТ6. Исходные данные 11,1 22,2 -33,3 -44,4 55,55 66,66 77,777 888,88 120,32 0 6 Ожидаемый результат: 55,55 66,66 77,777 888,88 120,32 0 11,1 22,2 -33,3 -44,4";
        public String TestString6 = "11,1 22,2 -33,3 -44,4 55,55 66,66 77,777 888,88 120,32 0 6";
        public String TestCase7 = "[INFO] ТЕСТ7. Исходные данные 11,1 22,2 -33,3 -44,4 55,55 66,66 77,777 888,88 120,32 0 5 left Ожидаемый результат: 66,66 77,777 888,88 120,32 0 11,1 22,2 -33,3 -44,4 55,55";
        public String TestString7 = "11,1 22,2 -33,3 -44,4 55,55 66,66 77,777 888,88 120,32 0 5 left";


        public void Info()
        {
            Console.WriteLine("[INFO]: Название: " + LabName);
            Console.WriteLine("[INFO]: Задание: " + Task);
            Console.WriteLine("[INFO]: Выполнил: " + Author);
            Console.WriteLine("[INFO]: Группа: " + Group);
        }
    }
    class ClassVector
    {
        public enum Direction {left, right}
        public static void Swap(ref double x, ref double y)
        {
            double swap = x;
            x = y;
            y = swap;
        }
        public static double SearchMax(double[] x)
        {
            double max = 0;
            for(int i = 0; i < x.Length; i++)
            {
                if (x[i] > max)
                {
                    max = x[i];
                }
            }
            return max;
        }
        public static void MirrorArray(ref double[] x)
        {
            double[] y = x;
            for (int i = 0; i < x.Length/2; i++)
            {
                ClassVector.Swap(ref x[i],ref y[y.Length-1-i]);
            }
        }

        public static void ShiftLeftStep(ref double[] x)
        {
            double safe;
            safe = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                x[i-1]=x[i];
            }
            x[x.Length-1] = safe;
        }
        public static void ShiftRightStep(ref double[] x)
        {
            double safe;
            safe = x[x.Length-1];
            for (int i = x.Length-1; i > 0; i--)
            {
                x[i] = x[i - 1];
            }
            x[0] = safe;
        }
        public static void MultiShiftLeftStep(ref double[] x, int ShiftCount)
        {
            for (int i = 0; i < ShiftCount; i ++)
            {
                ClassVector.ShiftLeftStep(ref x);
            }
        }
        public static void MultiShiftRightStep(ref double[] x, int ShiftCount)
        {
            for (int i = 0; i < ShiftCount; i++)
            {
                ClassVector.ShiftRightStep(ref x);
            }
        }
        public static void MultiShiftStep(ref double[] x, int ShiftCount, Direction direction)
        {
            switch (direction)
            {
                case Direction.left:
                    {
                        ClassVector.MultiShiftLeftStep(ref x, ShiftCount);
                        break;
                    }
                case Direction.right:
                    {
                        ClassVector.MultiShiftRightStep(ref x, ShiftCount);
                        break;
                    }
            }
        }
        public static double[] StringParser(String Input, int k,ref Direction direction,ref int ShiftCounter)
        {
            String[] InputArray = Input.Split(' ');
            double[] Output = new double[InputArray.Length-k];
            for (int i = 0; i < (InputArray.Length-k); i++)
            {
                Output[i] = double.Parse(InputArray[i]);
            }
            if (k == 1) ShiftCounter = int.Parse(InputArray[InputArray.Length-1]);
            if (k == 2)
            {
                ShiftCounter = int.Parse(InputArray[InputArray.Length - 2]);
                if (InputArray[InputArray.Length-1] == "left")
                    direction = Direction.left;
                else if (InputArray[InputArray.Length-1] == "right")
                    direction = Direction.right;
                else
                    direction = Direction.left;
            }
            return Output;
        }
    }

    class Program
    {
        static ClassVector.Direction direction = new ClassVector.Direction();
        static int ShiftCounter = 0;
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
                    Console.WriteLine("[MAIN]:  Инициализация функции SearchMax");
                    Console.WriteLine("[MAIN]: Max:" + ClassVector.SearchMax(ClassVector.StringParser(B.TestString1,0,ref Program.direction,ref Program.ShiftCounter)));
                    Console.WriteLine();

                    //Вызов тест кейса для 2 задания
                    double[] Vector2 = ClassVector.StringParser(B.TestString2, 0, ref Program.direction, ref Program.ShiftCounter);
                    Console.WriteLine(B.TestCase2);
                    Console.WriteLine("[MAIN]:  Инициализация функции MirrorArray");
                    ClassVector.MirrorArray(ref Vector2);
                    Console.Write("[MAIN]: Результат: ");
                    for (int i = 0; i < Vector2.Length; i++)
                    {
                        Console.Write(" " + Vector2[i]);
                    }
                    Console.WriteLine();

                    //Вызов тест кейса для 3 задания
                    double[] Vector3 = ClassVector.StringParser(B.TestString3, 0, ref Program.direction, ref Program.ShiftCounter);
                    Console.WriteLine(B.TestCase3);
                    Console.WriteLine("[MAIN]: Инициализацию функции ShiftLeftStep");
                    ClassVector.ShiftLeftStep(ref Vector3);
                    Console.Write("[MAIN]: Результат: ");
                    for (int i = 0; i < Vector3.Length; i++)
                    {
                        Console.Write(" " + Vector3[i]);
                    }
                    Console.WriteLine();

                    //Вызов тест кейса для 4 задания
                    double[] Vector4 = ClassVector.StringParser(B.TestString4, 1, ref Program.direction, ref Program.ShiftCounter);
                    Console.WriteLine(B.TestCase4);
                    Console.WriteLine("[MAIN]:  Инициализация функции MultiShiftLeftStep");
                    ClassVector.MultiShiftLeftStep(ref Vector4, Program.ShiftCounter);
                    Console.Write("[MAIN]: Результат: ");
                    for (int i = 0; i < Vector4.Length; i++)
                    {
                        Console.Write(" " + Vector4[i]);
                    }
                    Console.WriteLine();

                    //Вызов тест кейса для 5 задания
                    double[] Vector5 = ClassVector.StringParser(B.TestString5, 0, ref Program.direction, ref Program.ShiftCounter);
                    Console.WriteLine(B.TestCase5);
                    Console.WriteLine("[MAIN]:  Инициализация функции ShiftRightStep");
                    ClassVector.ShiftRightStep(ref Vector5);
                    Console.Write("[MAIN]: Результат: ");
                    for (int i = 0; i < Vector5.Length; i++)
                    {
                        Console.Write(" " + Vector5[i]);
                    }
                    Console.WriteLine();

                    //Вызов тест кейса для 6 задания
                    double[] Vector6 = ClassVector.StringParser(B.TestString6, 1, ref Program.direction, ref Program.ShiftCounter);
                    Console.WriteLine(B.TestCase6);
                    Console.WriteLine("[MAIN]: Инициализация функции MultiShiftRightStep");
                    ClassVector.MultiShiftRightStep(ref Vector6,Program.ShiftCounter);
                    Console.Write("[MAIN]: Результат: ");
                    for (int i = 0; i < Vector6.Length; i++)
                    {
                        Console.Write(" " + Vector6[i]);
                    }
                    Console.WriteLine();

                    //Вызов тест кейса для 7 задания
                    Console.WriteLine(B.TestCase7);
                    Console.WriteLine("[MAIN]: Инициализация функции MultiShiftStep");
                    double[] Vector7 = ClassVector.StringParser(B.TestString7, 2,ref direction,ref ShiftCounter);
                    ClassVector.MultiShiftStep(ref Vector7,ShiftCounter,direction);
                    Console.Write("[MAIN]: Результат: ");
                    for (int i = 0; i < Vector7.Length; i++)
                    {
                        Console.Write(" " + Vector7[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine("[MAIN]: Нажмите любую клавишу для продолжения");
                    Console.ReadLine();

                }
                else if (C == "2")
                {
                    Boolean check = true;
                    while (check == true)
                    {
                        Console.WriteLine("[MAIN]: Выберите используемую функцию для проверки цифрами 1-7, для вызова подсказки введите INFO");
                        String D = Console.ReadLine();
                        switch (D)
                        {
                            case "1":
                                {
                                    Console.WriteLine("[MAIN]: Выбрана функция SearchMax, введите строку со значениями в формате \"<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 1><'SPACE'><ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 2><'SPACE'>...<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ N>\"");
                                    String Input = Console.ReadLine();
                                    double[] InputArray = ClassVector.StringParser(Input, 0, ref Program.direction, ref ShiftCounter);
                                    Console.WriteLine("[MAIN]: Max:" + ClassVector.SearchMax(InputArray));
                                    Console.WriteLine();
                                    break;
                                }
                            case "2":
                                {
                                    Console.WriteLine("[MAIN]: Выбрана функция MirrorArray, введите строку со значениями в формате \"<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 1><'SPACE'><ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 2><'SPACE'>...<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ N>\"");
                                    String Input = Console.ReadLine();
                                    double[] InputArray = ClassVector.StringParser(Input, 0, ref Program.direction, ref ShiftCounter);
                                    ClassVector.MirrorArray(ref InputArray);
                                    Console.Write("[MAIN]: Результат: ");
                                    for (int i = 0; i < InputArray.Length; i++)
                                    {
                                        Console.Write(" " + InputArray[i]);
                                    }
                                    Console.WriteLine();
                                    break;
                                }
                            case "3":
                                {
                                    Console.WriteLine("[MAIN]: Выбрана функция ShiftLeftStep, введите строку со значениями в формате \"<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 1><'SPACE'><ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 2><'SPACE'>...<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ N>\"");
                                    String Input = Console.ReadLine();
                                    double[] InputArray = ClassVector.StringParser(Input, 0, ref Program.direction, ref ShiftCounter);
                                    ClassVector.ShiftLeftStep(ref InputArray);
                                    Console.Write("[MAIN]: Результат: ");
                                    for (int i = 0; i < InputArray.Length; i++)
                                    {
                                        Console.Write(" " + InputArray[i]);
                                    }
                                    Console.WriteLine();
                                    break;
                                }
                            case "4":
                                {
                                    Console.WriteLine("[MAIN]: Выбрана функция MultiShiftLeftStep, введите строку со значениями в формате \"<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 1><'SPACE'><ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 2><'SPACE'>...<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ N><'SPACE'><ЗНАЧЕНИЕ СДВИГА>\"");
                                    String Input = Console.ReadLine();
                                    double[] InputArray = ClassVector.StringParser(Input, 1, ref Program.direction, ref ShiftCounter);
                                    ClassVector.MultiShiftLeftStep(ref InputArray,ShiftCounter);
                                    Console.Write("[MAIN]: Результат: ");
                                    for (int i = 0; i < InputArray.Length; i++)
                                    {
                                        Console.Write(" " + InputArray[i]);
                                    }
                                    Console.WriteLine();
                                    break;
                                }
                            case "5":
                                {
                                    Console.WriteLine("[MAIN]: Выбрана функция ShiftRightStep, введите строку со значениями в формате \"<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 1><'SPACE'><ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 2><'SPACE'>...<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ N>\"");
                                    String Input = Console.ReadLine();
                                    double[] InputArray = ClassVector.StringParser(Input, 0, ref Program.direction, ref ShiftCounter);
                                    ClassVector.ShiftRightStep(ref InputArray);
                                    Console.Write("[MAIN]: Результат: ");
                                    for (int i = 0; i < InputArray.Length; i++)
                                    {
                                        Console.Write(" " + InputArray[i]);
                                    }
                                    Console.WriteLine();
                                    break;
                                }
                            case "6":
                                {
                                    Console.WriteLine("[MAIN]: Выбрана функция MultiShiftRightStep, введите строку со значениями в формате \"<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 1><'SPACE'><ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 2><'SPACE'>...<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ N><'SPACE'><ЗНАЧЕНИЕ СДВИГА>\"");
                                    String Input = Console.ReadLine();
                                    double[] InputArray = ClassVector.StringParser(Input, 1, ref Program.direction, ref ShiftCounter);
                                    ClassVector.MultiShiftRightStep(ref InputArray, ShiftCounter);
                                    Console.Write("[MAIN]: Результат: ");
                                    for (int i = 0; i < InputArray.Length; i++)
                                    {
                                        Console.Write(" " + InputArray[i]);
                                    }
                                    Console.WriteLine();
                                    break;
                                }
                            case "7":
                                {
                                    Console.WriteLine("[MAIN]: Выбрана функция MultiShiftRightStep, введите строку со значениями в формате \"<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 1><'SPACE'><ЗНАЧЕНИЕ ПЕРЕМЕННОЙ 2><'SPACE'>...<ЗНАЧЕНИЕ ПЕРЕМЕННОЙ N><'SPACE'><ЗНАЧЕНИЕ СДВИГА><'SPACE'><НАПРАВЛЕНИЕ:{left,right}>\"");
                                    String Input = Console.ReadLine();
                                    double[] InputArray = ClassVector.StringParser(Input, 2, ref Program.direction, ref ShiftCounter);
                                    ClassVector.MultiShiftStep(ref InputArray, ShiftCounter, Program.direction);
                                    Console.Write("[MAIN]: Результат: ");
                                    for (int i = 0; i < InputArray.Length; i++)
                                    {
                                        Console.Write(" " + InputArray[i]);
                                    }
                                    Console.WriteLine();
                                    break;
                                }
                            case "INFO":
                                {
                                    Console.WriteLine("[MAIN]: Для вызова функций воспользуйтесь клавишами с цифрами от 1 до 7");
                                    Console.WriteLine("[MAIN]: 1: Вызов функции поиска максимального значения в массиве");
                                    Console.WriteLine("[MAIN]: 2: Вызов функции зеркалирования значений в массиве");
                                    Console.WriteLine("[MAIN]: 3: Вызов функции сдвига массива на 1 шаг влево");
                                    Console.WriteLine("[MAIN]: 4: Вызов функции сдвига массива на N шагов влево");
                                    Console.WriteLine("[MAIN]: 5: Вызов функции сдвига массива на 1 шаг вправо");
                                    Console.WriteLine("[MAIN]: 6: Вызов функции сдвига массива на N шагов вправо");
                                    Console.WriteLine("[MAIN]: 7: Вызов функции сдвига массива на N шагов в заданном направлении");
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