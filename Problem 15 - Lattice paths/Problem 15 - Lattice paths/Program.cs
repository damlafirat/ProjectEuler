using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_15___Lattice_paths
{
    /*
     * Lattice paths
     * Problem 15
     * Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
     * How many such routes are there through a 20×20 grid?
     * */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(combination(20, 20));
            Console.ReadLine();
        }

        private static BigInteger combination(int num1, int num2)
        {
            return fakt(num1 + num2) / fakt(num1) / fakt(num2);
        }

        private static BigInteger fakt(int num)
        {
            BigInteger product = 1;

            for (int i = 1; i <= num; i++)
            {
                product *= i;
            }

            return product;
        }
    }
}
