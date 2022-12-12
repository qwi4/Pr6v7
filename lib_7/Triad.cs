using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    /// <summary>
    /// Класс для создания триад и работы с ними
    /// </summary>
    public class Triad
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        private int v1;
        private int v2;
        private int v3;


        public Triad(int v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        /// <summary>
        /// автоматические св-ва
        /// </summary>
        public int One { get => v1; set => v1 = value; } //Первое число
        public int Two { get => v2; set => v2 = value; } //Второе число
        public int Three { get => v3; set => v3 = value; } //Третье число

        /// <summary>
        /// Сравнивание чисел в триадах
        /// </summary>
        /// <returns>true or false</returns>
        public bool Compare(Triad triad)
        {
            return One > triad.One || One == triad.One && Two > triad.Two && Three > triad.Two;
        }

        /// <summary>
        /// Правильный вывод триад
        /// </summary>
        /// <returns>триады One, Two. Three</returns>
        public override string ToString()
        {
            return $"{One}, {Two}, {Three}";
        }

        /// <summary>
        /// Увелечение значений на 10 (перегрузки)
        /// </summary>
        /// <param name="One"></param>
        /// <param name="Two"></param>
        /// <param name="Three"></param>
        public void SetParams()
        {
            One += 10;
            Two += 10;
            Three += 10;
        }

        public void SetParams(int one)
        {
            One = one;
        }

        public void SetParams(int one, int two)
        {
            One = one;
            Two = two;
        }

        /// <summary>
        /// Перегрузка операторов 
        /// </summary>
        public static bool operator >(Triad t1, Triad t2)
        {
            if (t1.One > t2.One || t1.One == t2.One && t1.Two > t2.Two && t1.Three > t2.Two) return true;
            else return false;
            
        }
        public static bool operator <(Triad t1, Triad t2)
        {
            return false;
        }

       public static Triad operator ++(Triad number)
        {
            Triad count10 = new Triad(number.One+=10, number.Two+=10, number.Three+=10);
            return count10;
        }
    }
}
// return One > triad.One || One == triad.One && Two > triad.Two && Three > triad.Two;
