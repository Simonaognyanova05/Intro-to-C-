﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam___5
{
    internal class Program
    {
        static void PrintMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int[,] InitMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i < j)
                    {
                        matrix[i, j] = 4 * j - (i * i * i);
                    }
                    else if (i == j)
                    {
                        matrix[i,j] = 0;
                    } 
                    else if (i > j)
                    {
                        matrix[i, j] = i + j;
                    }
                }
            }

            return matrix;
        }

        static int[] GetRowsSum(int[,] matrix)
        {
            int[] sums = new int[matrix.GetLength(0)];
            int sum = 0;

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int k = 0;  k < matrix.GetLength(1); k++)
                {
                    sum += matrix[i, k];
                }
                sums[i] = sum;
                sum = 0;
            }

            return sums;
        }
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {6, 7, 8 },
            };

            int[,] newMatrix = InitMatrix(matrix);
            PrintMatrix(newMatrix);

            int[] sumOfrows = GetRowsSum(matrix);
            Console.WriteLine(string.Join(" ", sumOfrows));
        }
    }
}
