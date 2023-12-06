using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    public class Mathe
    {
        /// <summary>
        /// Summiere die Werte
        /// </summary>
        /// <param name="a">Summand 1</param>
        /// <param name="b">Summand 2</param>
        /// <returns>Summe</returns>
        public static int Summe(int a, int b)
        {
            return a + b; 
        }
        /// <summary>
        /// Subtrahiert die Werte
        /// </summary>
        /// <param name="a">Minuend a</param>
        /// <param name="b">Subtrahend b</param>
        /// <returns>Differenz</returns>
        public static int Subtraktion(int a, int b)
        {
            return a - b;
        }
        /// <summary>
        /// Multipliziert die Werte
        /// </summary>
        /// <param name="a">Multiplikator a</param>
        /// <param name="b">Multiplikator b</param>
        /// <returns>Produkt</returns>
        public static int Multiplikation(int a, int b)
        {
            return a * b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">Divident a</param>
        /// <param name="b">Divisor b</param>
        /// <returns>Quotient</returns>
        public static int Division(int a, int b)
        {
            //if (b == 0) throw new ArgumentException("b muss größer als null sein");

            return a / b;

        }
    }
}
