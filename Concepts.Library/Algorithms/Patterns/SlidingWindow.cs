using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.Library.Algorithms.Patterns
{
    public class SlidingWindow
    {
        public void Run()
        {
            int[] arr = new int[] { 4, 9, 10, 19, 12, 3 };
            int n = arr.Length;
            int k = 2;


            for(int i = 0; i <= n-k; i++)
            {
                for(int j = 0; j < k; j++)
                {
                    Console.Write($"{arr[i + j]},");
                }

                Console.WriteLine();

            }

        }
    }
}
