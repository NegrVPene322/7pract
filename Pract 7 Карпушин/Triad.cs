using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pract_7_Карпушин
{
    internal class Triad
    {
        /// <summary>
        /// Свойства для полей
        /// </summary>
        public int First { get; private set; }
        public int Second { get; private set; }
        public int Third { get; private set; }


        /// <summary>
        /// Конструктор для полей
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        public Triad(int first, int second, int third)
        {
            if (!IsOdd(first) || !IsOdd(second) || !IsOdd(third))
            {
                MessageBox.Show("Числа должны быть нечетными");

            }
            else
            {
                First = first;
                Second = second;
                Third = third;
            }
        }
        public Triad() { }

        /// <summary>
        /// Метод для проверки на нечетность
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private bool IsOdd(int number)
        {
            return number % 2 != 0;
        }


        /// <summary>
        /// Метод для сравнивания 2 троек
        /// </summary>
        /// <param name="obj"></param>
        /// <returns> Возвращает true/ false</returns>
        public override bool Equals(object obj)
        {
            if (obj is Triad other)
            {
                return this.First == other.First &&
                       this.Second == other.Second &&
                       this.Third == other.Third;
            }
            return false;
        }
        public static bool operator ==(Triad triad1, Triad triad2)
        {
            bool result;
            if ((triad1.First == triad2.First) && (triad1.Second == triad2.Second) && (triad1.Third == triad2.Third)) result = true;
            else result = false;
            return result;
        }
        /// <summary>
        /// Парная перегрузка оператора сравнения
        /// </summary>
        /// <param name="triad1"></param>
        /// <param name="triad2"></param>
        /// <returns></returns>
        public static bool operator !=(Triad triad1, Triad triad2)
        {
            bool result;
            if ((triad1.First == triad2.First) && (triad1.Second == triad2.Second) && (triad1.Third == triad2.Third)) result = false;
            else result = true;
            return result;
        }


        /// <summary>
        /// Метод для сравнивания 3 троек
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns> Возвращает true/ false </returns>
        public static bool Equals(Triad a, Triad b, Triad c)
        {
            return a.Equals(b) && b.Equals(c);
        }
    }
}
