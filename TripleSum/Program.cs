﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var count = 0;
            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = a+1; b < arr.Length; b++)
                {
                    var sum = arr[a] + arr[b];
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine($"{arr[a]} + {arr[b]} == {sum}");
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
            {

            }
        }
    }
}
