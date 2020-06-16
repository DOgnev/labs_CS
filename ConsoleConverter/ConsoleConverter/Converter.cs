using System;
using System.Text.RegularExpressions;

namespace ConsoleConverter
{
    //Определение класса Converter
    class Converter
    {
        //Раздел описания переменных и структур
        int Base;
        String String_Value;
        Value value = new Value();
        class Value
        {
            public String IntPart;
            public String FracPart;
            public Value()
            {
                this.IntPart = "0";
                this.FracPart = "0";
            }
            public Value(String IntPart, String FracPart)
            {
                this.IntPart = IntPart;
                this.FracPart = FracPart;
            }

        }

        public Converter(int Base, String Value)
        {
            this.Base = Base;
            this.String_Value = Value;
        }
        public Converter()
        {
            this.Base = 10;
            this.String_Value = "0";
        }
        //Определение метода Parser для обработки данных
        public Boolean Parser(String Input)
        {
            // Определяем регулярное выражение для входной строки данных
            Regex InputRegExp = new Regex("^(?<Base>[0-9]{1,2})[ ](?<IntPart>[0-9ABCDEFabcdef]*)[.,]{0,1}(?<FracPart>[0-9ABCDEFabcdef]*)$");
            MatchCollection matches = InputRegExp.Matches(Input);
            // Проверка, что мы имеем строго 1 строку в совпадении
            if (matches.Count == 0 || matches.Count > 1)
            {
                Console.WriteLine("[MAIN-Parser]: Строка не удовлетворяет заданным требованиям.");
                return false;
            }
            // Для каждого совпадения (1 строка) выполняем действия ниже
            foreach (Match match in matches)
            {
                //Вызываем метод Base_checker для группы Base из строки совпадения (основание)
                if (!Base_checker(int.Parse(match.Groups["Base"].Value)))
                {
                    Console.WriteLine("[MAIN-Base_checker]: Основание не соответсвует требованиям");
                    return false;
                }
                //Если цикл не упал, то присваиваем переменной Base значение из группы
                this.Base = int.Parse(match.Groups["Base"].Value);
                //Проверяем целую часть через метод Value_check
                if (Value_checker(match.Groups["IntPart"].Value) == -2)
                {
                    Console.WriteLine("[MAIN-Value_checker]: Неожиданная ошибка");
                    return false;
                }
                if (Value_checker(match.Groups["IntPart"].Value) != -1 && Value_checker(match.Groups["IntPart"].Value) != -2)
                {
                    Console.WriteLine("[MAIN-Value_checker]: Неожиданный символ в позиции: " + Value_checker(match.Groups["IntPart"].Value));
                    return false;
                }
                //Проверяем дробную часть через метод Value_check
                if (Value_checker(match.Groups["FracPart"].Value) == -2)
                {
                    Console.WriteLine("[MAIN-Value_checker]: Неожиданная ошибка");
                    return false;
                }
                if (Value_checker(match.Groups["FracPart"].Value) != -1 && Value_checker(match.Groups["IntPart"].Value) != -2)
                {
                    Console.WriteLine("[MAIN-Value_checker]: Неожиданный символ в позиции: " + (Value_checker(match.Groups["FracPart"].Value)+ match.Groups["IntPart"].Value.Length + 1));
                    return false;
                }
                //Если целая часть не пустая, то присваиваем её локальной переменной
                if (!(match.Groups["IntPart"].Length == 0))
                {
                    this.value.IntPart = match.Groups["IntPart"].Value;
                }
                else
                {
                    Console.WriteLine("[MAIN-Value_checker]: Пустая целая часть числа");
                    return false;
                }
                //Если дробная часть не пустая, то присваиваем её локальной переменной
                if (!(match.Groups["FracPart"].Length == 0))
                {
                    this.value.FracPart = match.Groups["FracPart"].Value;
                }

            }
            //Если не вылетели из цикла, то возвращаем методу истину
            return true;
        }
        public Boolean Base_checker(int Input)
        //Выполняем проверку основания
        {
            for (int i = 2; i < 17; i++)
            {
                if (Input == i && Input != 10)
                {
                    return true;
                }
            }
            return false;
        }

        public int Value_checker(String Input)
        //Выполняем проверку значения числа (дробной или целой части) исходя из набора регулярных выражений, выбор которых зависит от основания, если терпим неудачу, то возвращаем позицию первого неудачного символа.
        {
            Regex Regexp_2 = new Regex("[0-1]");
            Regex Regexp_3 = new Regex("[0-2]");
            Regex Regexp_4 = new Regex("[0-3]");
            Regex Regexp_5 = new Regex("[0-4]");
            Regex Regexp_6 = new Regex("[0-5]");
            Regex Regexp_7 = new Regex("[0-6]");
            Regex Regexp_8 = new Regex("[0-7]");
            Regex Regexp_9 = new Regex("[0-8]");
            Regex Regexp_11 = new Regex("[0-9Aa]");
            Regex Regexp_12 = new Regex("[0-9ABab]");
            Regex Regexp_13 = new Regex("[0-9ABCabc]");
            Regex Regexp_14 = new Regex("[0-9ABCDabcd]");
            Regex Regexp_15 = new Regex("[0-9ABCDEabcde]");
            Regex Regexp_16 = new Regex("[0-9ABCDEFabcdef]");
            int i;
            switch (this.Base)
            {
                case 2:
                    {
                        for (i = 0; i < Input.Length; i++)
                        {
                            if (!Regexp_2.IsMatch(Input[i].ToString()))
                            {
                                return i;
                            }
                        }
                        return -1;
                    }
                case 3:
                    {
                        for (i = 0; i < Input.Length; i++)
                        {
                            if (!Regexp_3.IsMatch(Input[i].ToString()))
                            {
                                return i;
                            }
                        }
                        return -1;
                    }
                case 4:
                    {
                        for (i = 0; i < Input.Length; i++)
                        {
                            if (!Regexp_4.IsMatch(Input[i].ToString()))
                            {
                                return i;
                            }
                        }
                        return -1;
                    }
                case 5:
                    {
                        for (i = 0; i < Input.Length; i++)
                        {
                            if (!Regexp_5.IsMatch(Input[i].ToString()))
                            {
                                return i;
                            }
                        }
                        return -1;
                    }
                case 6:
                    {
                        for (i = 0; i < Input.Length; i++)
                        {
                            if (!Regexp_6.IsMatch(Input[i].ToString()))
                            {
                                return i;
                            }
                        }
                        return -1;
                    }
                case 7:
                    {
                        for (i = 0; i < Input.Length; i++)
                        {
                            if (!Regexp_7.IsMatch(Input[i].ToString()))
                            {
                                return i;
                            }
                        }
                        return -1;
                    }
                case 8:
                    {
                        for (i = 0; i < Input.Length; i++)
                        {
                            if (!Regexp_8.IsMatch(Input[i].ToString()))
                            {
                                return i;
                            }
                        }
                        return -1;
                    }
                case 9:
                    {
                        for (i = 0; i < Input.Length; i++)
                        {
                            if (!Regexp_9.IsMatch(Input[i].ToString()))
                            {
                                return i;
                            }
                        }
                        return -1;
                    }
                case 11:
                    {
                        for (i = 0; i < Input.Length; i++)
                        {
                            if (!Regexp_11.IsMatch(Input[i].ToString()))
                            {
                                return i;
                            }
                        }
                        return -1;
                    }
                case 12:
                    {
                        for (i = 0; i < Input.Length; i++)
                        {
                            if (!Regexp_12.IsMatch(Input[i].ToString()))
                            {
                                return i;
                            }
                        }
                        return -1;
                    }
                case 13:
                    {
                        for (i = 0; i < Input.Length; i++)
                        {
                            if (!Regexp_13.IsMatch(Input[i].ToString()))
                            {
                                return i;
                            }
                        }
                        return -1;
                    }
                case 14:
                    {
                        for (i = 0; i < Input.Length; i++)
                        {
                            if (!Regexp_14.IsMatch(Input[i].ToString()))
                            {
                                return i;
                            }
                        }
                        return -1;
                    }
                case 15:
                    {
                        for (i = 0; i < Input.Length; i++)
                        {
                            if (!Regexp_15.IsMatch(Input[i].ToString()))
                            {
                                return i;
                            }
                        }
                        return -1;
                    }
                case 16:
                    {
                        for (i = 0; i < Input.Length; i++)
                        {
                            if (!Regexp_16.IsMatch(Input[i].ToString()))
                            {
                                return i;
                            }
                        }
                        return -1;
                    }
                default:
                    {
                        return -2;
                    }
            }
        }
        public String CompleteConvert()
        //Выполнеям вычисление по переводу из системы p в 10 - ую
        {
            int i;
            int Def = 0;
            double Result = 0.0;
            int IntResult = 0;
            double FracResult = 0.0;
            for (i = value.IntPart.Length - 1; i > -1; i--)
            {   

                IntResult += (Transfer(value.IntPart[i].ToString())*(int) Math.Pow((double)this.Base,(double)Def));
                Def += 1;
            }
            Def = -1;
            for (i = 0; i < value.FracPart.ToString().Length; i++)
            {
                FracResult += (Transfer(value.FracPart[i].ToString()) * Math.Pow((double)this.Base, (double)Def));
                Def -= 1;
            }
            Result = IntResult + FracResult;
            return Result.ToString();
        }
        public int Transfer(String Input)
        //Функция выполняет согласование символов со значением
        {
            switch (Input)
            {
                case "A":
                    {
                        return 10;
                    }
                case "B":
                    {
                        return 11;
                    }
                case "C":
                    {
                        return 12;
                    }
                case "D":
                    {
                        return 13;
                    }
                case "E":
                    {
                        return 14;
                    }
                case "F":
                    {
                        return 15;
                    }
                default:
                    {
                        return int.Parse(Input);
                    }
            }
        }
        public void Fresh()
        //Выполнеям очистку локальных переменных.
        {
            this.value.IntPart = "";
            this.value.FracPart = "";
            this.Base = 0;
        }
    }
}
