﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] tab = new int[][]

            {
                new int[] { 1, 2},
                new int[] { 3, 4, 5},
                new int[] {6}

            };

            /*
             * wyswietl zawartosc tablicy za pomoca dwoch petli for
             * 
             * 
             */

            for (int i = 0; i < tab.GetLength(0); i++)
            {

              
                for (int j = 0; j < tab[i].Length; j++)
                {
                    Console.WriteLine("{0} ", tab[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
