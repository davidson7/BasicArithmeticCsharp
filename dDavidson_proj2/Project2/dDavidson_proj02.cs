using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class dDavidson_proj02
    {
        static void Main(string[] args)
        {
            ///<summary>Sets two values to be calculated, performs five arithmetic operations,
            ///and prints to console. Waits for input to close console.</summary>
            
            int x = 42;
            int y = 19;
            Console.WriteLine(x + "\tand\t"+ y);
            Console.WriteLine("x+y= "+Sum(x, y));
            Console.WriteLine("x-y= "+Difference(x, y));
            Console.WriteLine("x/y= "+Divide(x, y));
            Console.WriteLine("x*y= "+Multiply(x, y));
            Console.WriteLine("x%y= "+Modulo(x, y));
            Console.ReadLine();

        }
        /// <summary>Sums the two inputs into a single value.</summary>
        /// <param name="x">The first value.param>
        /// <param name="y">The second value.param>
        /// <returns>Returns the sum.</returns>
        static int Sum(int x, int y)
        {
            return x + y;
        }
        /// <summary>Subtracts the two inputs into a single value.</summary>
        /// <param name="x">The first value.param>
        /// <param name="y">The second value.param>
        /// <returns>Returns the difference.</returns>
        static int Difference(int x, int y)
        {
            return x - y;
        }
        /// <summary>Multiplies the two inputs into a single value.</summary>
        /// <param name="x">The first value.param>
        /// <param name="y">The second value.param>
        /// <returns>Returns the product.</returns>
        static int Multiply(int x, int y)
        {
            return x * y;
        }
        /// <summary>Divides the two inputs into a single value.</summary>
        /// <param name="x">The first value.param>
        /// <param name="y">The second value.param>
        /// <returns>Returns the quotient.</returns>
        static int Divide(int x, int y)
        {
            return x / y;
        }
        /// <summary>Divides the two inputs and puts the remainder into a single value.</summary>
        /// <param name="x">The first value.param>
        /// <param name="y">The second value.param>
        /// <returns>Returns the remainder.</returns>
        static int Modulo(int x, int y)
        {
            return x % y;
        }
    }
    
}
