using System;

namespace TSet
{
    class Program
    {
        static void Main(string[] args)
        {
            TSet<int> TestInt = new TSet<int>();
            TSet<char> TestChar = new TSet<char>();
            TSet<int> TestIntEmpty = new TSet<int>();
            TSet<int> Test = new TSet<int>();
            //Забор тестовых данных
            Console.WriteLine("[MAIN]: Введите тип данных для инициализации");
            Console.WriteLine("[MAIN]: 1 множество");
            TestInt.AddToSet(0);
            TestInt.AddToSet(1);
            TestInt.AddToSet(2);
            TestInt.AddToSet(3);
            TestInt.AddToSet(4);
            TestInt.AddToSet(5);
            TestInt.AddToSet(0);
            Console.WriteLine("[MAIN]: " + TestInt.SetToString());
            Console.WriteLine();
            Console.WriteLine("2 множество");
            TestChar.AddToSet('A');
            TestChar.AddToSet('B');
            TestChar.AddToSet('C');
            TestChar.AddToSet('D');
            TestChar.AddToSet('E');
            TestChar.AddToSet('F');
            TestChar.AddToSet('R');
            TestChar.AddToSet('A');
            TestChar.AddToSet('T');
            Console.WriteLine("[MAIN]: " + TestChar.SetToString());
            Console.WriteLine();
            Console.WriteLine("[MAIN]: 3 множество");
            TestIntEmpty.AddToSet(6);
            TestIntEmpty.AddToSet(7);
            TestIntEmpty.AddToSet(8);
            Console.WriteLine("[MAIN]: " + TestIntEmpty.SetToString());
            Console.WriteLine();
            Console.WriteLine("[MAIN]: Функция добавить 9 и 10");
            Console.WriteLine("[MAIN]: " + TestIntEmpty.SetToString());
            TestIntEmpty.AddToSet(9);
            TestIntEmpty.AddToSet(10);
            Console.WriteLine("[MAIN]: " + TestIntEmpty.SetToString());
            Console.WriteLine();
            Console.WriteLine("[MAIN]: Функция удалить 9 и 10");
            Console.WriteLine("[MAIN]: " + TestIntEmpty.SetToString());
            TestIntEmpty.DeleteFromSet(9);
            TestIntEmpty.DeleteFromSet(10);
            Console.WriteLine("[MAIN]: " + TestIntEmpty.SetToString());
            Console.WriteLine();
            Console.WriteLine("[MAIN]: Функция пусто");
            Console.WriteLine("[MAIN]: " + TestIntEmpty.SetToString());
            Console.WriteLine("[MAIN]: " + TestIntEmpty.IfEmpty());
            Console.WriteLine("[MAIN]: " + Test.SetToString());
            Console.WriteLine("[MAIN]: " + Test.IfEmpty());
            Console.WriteLine();
            Console.WriteLine("[MAIN]: Функция пренадлежит");
            Console.WriteLine("[MAIN]: " + TestIntEmpty.SetToString());
            Console.WriteLine("[MAIN]: " + TestIntEmpty.IfContains(6));
            Console.WriteLine("[MAIN]: " + Test.SetToString());
            Console.WriteLine("[MAIN]: " + Test.IfContains(0));
            Console.WriteLine("[MAIN]: Функция опустошить");
            Console.WriteLine("[MAIN]: " + TestChar.SetToString());
            TestChar.SetToVoid();
            Console.WriteLine("[MAIN]: " + TestChar.SetToString());
            Console.WriteLine();
            Console.WriteLine("[MAIN]: Функция объединить");
            Console.WriteLine("[MAIN]: " + TestInt.SetToString());
            Console.WriteLine("[MAIN]: " + TestIntEmpty.SetToString());
            TestInt.Compare(TestIntEmpty);
            Console.WriteLine("[MAIN]: " + TestInt.SetToString());
            Console.WriteLine();
            Console.WriteLine("[MAIN]: Функция вычесть");
            Console.WriteLine("[MAIN]: " + TestInt.SetToString());
            Console.WriteLine("[MAIN]: " + TestIntEmpty.SetToString());
            TestInt.Subtract(TestIntEmpty);
            Console.WriteLine("[MAIN]: " + TestInt.SetToString());
            Console.WriteLine();
            Console.WriteLine("[MAIN]: Функция умножить");
            TestInt.Compare(TestIntEmpty);
            Console.WriteLine("[MAIN]: " + TestInt.SetToString());
            Console.WriteLine("[MAIN]: " + TestIntEmpty.SetToString());
            TestInt.Mult(TestIntEmpty);
            Console.WriteLine("[MAIN]: " + TestInt.SetToString());
            Console.WriteLine();
            Console.WriteLine("[MAIN]: Функция равно");
            TestInt.AddToSet(0);
            TestInt.AddToSet(1);
            TestInt.AddToSet(2);
            Console.WriteLine("[MAIN]: " + TestInt.SetToString() + "and" + TestIntEmpty.SetToString());
            Console.WriteLine("[MAIN]: " + TestIntEmpty.SetToString() + "and" + TestIntEmpty.SetToString());
            Console.WriteLine("[MAIN]: " + TestInt.Equal(TestIntEmpty));
            Console.WriteLine("[MAIN]: " + TestInt.Equal(TestInt));
            Console.WriteLine();
            Console.WriteLine("[MAIN]: Функция неравно");
            Console.WriteLine("[MAIN]: " + TestInt.SetToString() +"and"+ TestIntEmpty.SetToString());
            Console.WriteLine("[MAIN]: " + TestIntEmpty.SetToString() + "and" + TestIntEmpty.SetToString());
            Console.WriteLine("[MAIN]: " + TestInt.UnEqual(TestIntEmpty));
            Console.WriteLine("[MAIN]: " + TestInt.UnEqual(TestInt));
            Console.WriteLine();
            Console.WriteLine("[MAIN]: Функция количество элементов");
            Console.WriteLine("[MAIN]: " + TestInt.SetToString());
            Console.WriteLine("[MAIN]: " + TestInt.Counter());
            Console.WriteLine();
            Console.WriteLine("[MAIN]: Функция элемент [0]");
            Console.WriteLine("[MAIN]: " + TestInt.SetToString());
            Console.WriteLine("[MAIN]: " + TestInt.Show(0));
            Console.WriteLine("[MAIN]: " + TestInt.Show(7));
            Console.WriteLine();




        }
    }
}