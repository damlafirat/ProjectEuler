using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9___Special_Pythagorean_triplet
{
    /*
     * Special Pythagorean triplet
     * Problem 9 
     * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
     *a^2 + b^2 = c^2
     * For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
     * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
     * Find the product abc.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(pisagorNumbers());
            Console.ReadLine();
        }

        private static int pisagorNumbers()
        {
            int product = 1;

            for (int i = 1; i < 999; i++)
            {
                for (int j = 1; j < 999; j++)
                {
                    int k = 1000 - (i + j);

                    if (k > i && i > j)
                    {
                        if (Math.Pow(i, 2) + Math.Pow(j, 2) == Math.Pow(k, 2))
                        {
                            product = i * j * k;
                        }
                    }
                }
            }
            return product;
        }
    }
}
