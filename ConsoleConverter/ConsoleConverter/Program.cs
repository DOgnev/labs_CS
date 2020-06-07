using System;

namespace ConsoleConverter
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Converter Index = new Converter();
            
            while (true)
            {
                String Cheaker;
                Console.WriteLine("[MAIN]: Введите exit для выхода, info для информации о программе, для продолжения нажмите любую клавишу.");
                Cheaker = Console.ReadLine();
                if (Cheaker == "exit")
                {
                    break;
                }
                if (Cheaker == "info")
                {
                    Info info = new Info();
                    info.ShowInfo();
                }
                else
                {
                    while (true)
                    {
                        String Input;
                        Console.WriteLine("[MAIN]: Перевод чисел из P-ичного основания в десятичное.");
                        Console.WriteLine("[MAIN]: Введите данные в формате: [Основание][Пробел][Число]");
                        Input = Console.ReadLine();
                        if (Index.Parser(Input))
                        {
                            Console.WriteLine("[MAIN]: Результат перевода: " + Index.CompleteConvert());
                            Index.Fresh();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
