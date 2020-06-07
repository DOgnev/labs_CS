using System;

namespace ConsoleConverter
{
    class Info
    {
        String Intro, Name, Task, Version;
        public Info()
        {
            this.Intro = "Расчетное - графическое задание: Современные технологии в программировании (Конвертер)";
            this.Name = "Студент группы МГ-196 Огнев Даниил";
            this.Task = "Реализовать консольную программу, выполняющую преобразование входного числа с заданным основанием (2-16) в десятичное число";
            this.Version = "Вариант 30";      
        }
        public void ShowInfo()
        {
            Console.WriteLine("[INFO]: " + this.Intro);
            Console.WriteLine("[INFO]: Выполнил: " + this.Name);
            Console.WriteLine("[INFO]: Задание: " + this.Task);
            Console.WriteLine("[INFO]: " + this.Version);
        }
    }
}
