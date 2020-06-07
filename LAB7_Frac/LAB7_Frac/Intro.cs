using System;
using System.Collections.Generic;
using System.Text;

namespace LAB7_Frac
{
    class Intro
    {
        public String LabName = "Лабораторная работа №6: Редактор абстрактного типа данных \"Простая дробь\".";
        public String Author = "Даниил Огнев";
        public String Group = "МГ-196";
        public String Task = "Задание. Разработать класс для редактирования типа данных \"Простая дробь\".";

        public void Info()
        {
            Console.WriteLine("[INFO]: Название: " + LabName);
            Console.WriteLine("[INFO]: Задание: " + Task);
            Console.WriteLine("[INFO]: Выполнил: " + Author);
            Console.WriteLine("[INFO]: Группа: " + Group);
        }
    }
}