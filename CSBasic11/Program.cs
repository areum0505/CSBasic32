﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> output1 = new List<int>();
            List<int> output2 = new List<int>();
            foreach (var item in input)
            {
                if(item % 2 == 0)
                {
                    output1.Add(item);
                }
            }
            foreach (var item in output1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            output2 = (from item in input
                       where item % 2 == 0
                       orderby item descending
                       select item).ToList();
            foreach (var item in output2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
