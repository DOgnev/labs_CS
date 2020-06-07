using System;
using System.Collections.Generic;

namespace TSet
{
    class TSet<T>
    {
        List<T> Set;

        //Объявление конструктора класса Множество
        public TSet()
        {
            Set = new List<T>();
        }
        //Возвращает значение i элемента класса Множество
        public T this[int i]
        {
            get
            {
                return Set[i];
            }
        }
        //Формирует строку из элементов класса Множество
        public String SetToString()
        {
            String result = "";
            for (int i = 0; i < Set.Count; i++)
            {
                if (!result.Equals(""))
                {
                    result += "; " + Set[i];
                }
                else
                {
                    result += Set[i];
                }
            }
            if (result != "")
            {
                return result;
            }
            else
            {
                return "Empty TSet";
            }
        }
        // Метод "Добавить". Определяет элемент для включения в класс Множество. 
        public void AddToSet(T Input)
        {
            if (!Set.Contains(Input))
            {
                Set.Add(Input);
            }
        }
        // Метод "Удалить". Определяет элемент для удаления из класса Множество.
        public void DeleteFromSet(T Input)
        {
            if (Set.Contains(Input))
            {
                Set.Remove(Input);
            }
        }
        // Метод "Опустошить". Определяет Множество, как пустое.
        public void SetToVoid()
        {
            Set.Clear();
        }
        // Метод "Пусто". Выполняет проверку Множества на наличие элементов.
        public Boolean IfEmpty()
        {
            if (Set.Count.Equals(0))
                return true;
            return false;
        }
        // Метод "Принадлежит". Выполняет проверку Множество на наличие заданного элемента.
        public Boolean IfContains(T Input)
        {
            if (Set.Contains(Input))
                return true;
            return false;
        }
        // Метод "Объеденить". Выполняет объединение двух Множеств в одно.
        public TSet<T> Compare(TSet<T> Input)
        {
            for (int i = 0; i < Input.Set.Count; i++)
            {
                if (!this.Set.Contains(Input.Set[i]))
                    this.Set.Add(Input.Set[i]);
            }
            return this;
        }

        // Метод "Вычесть". Выполняет вычитание двух Множеств.
        public TSet<T> Subtract(TSet<T> Input)
        {
            for (int i = 0; i < Input.Set.Count; i++)
            {
                if (this.Set.Contains(Input.Set[i]))
                    this.Set.Remove(Input.Set[i]);
            }
            return this;
        }

        // Метод "Умножить". Выполняет умножение двух Множеств.
        public TSet<T> Mult(TSet<T> Input)
        {
            TSet<T> Ext = new TSet<T>();
            for (int i = 0; i < Input.Set.Count; i++)
            {
                if (this.Set.Contains(Input.Set[i]))
                    Ext.Set.Add(Input.Set[i]);
            }
            this.Set = Ext.Set;
            return this;
        }

        // Метод "Равно". Проверка двух Множеств на равенство.
        public Boolean Equal(TSet<T> Input_2)
        {
            if (this.Set.Count != Input_2.Set.Count)
            {
                return false;
            }
        for (int i = 0; i< this.Set.Count; i++)
        {
                if (!this.Set.Contains(Input_2.Set[i]))
                {
                    return false;
                }
                    
        }
            return true;
        }
        // Метод "Неравно". Проверка двух Множеств на неравенство.
        public Boolean UnEqual(TSet<T> Input_2)
        {
            if (!this.Equal(Input_2))
                return true;
            return false;
        }

        // Метод "Подсчет". Возвращает количество элементов в Множестве.
        public int Counter()
        {
            return this.Set.Count;
        }

        // Метод "Элемент". Возвращает элемент из Множества.
        public T Show(int Index)
        {
            if (Index < this.Set.Count)
            {
                return this.Set[Index];
            }
            else
            {
                Console.WriteLine("No element");
            }
            return default(T);
        }
    }
}
