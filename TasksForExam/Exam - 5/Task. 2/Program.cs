﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._2
{
    internal class Program
    {
        static double[] ReadArrayFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            string[] array = lines[0].Split('\t');

            double[] nums = new double[array.Length];

            for(int i = 0; i < array.Length; i++)
            {
                nums[i] = double.Parse(array[i]);   
            }

            return nums;
        }

        static double[] MoveZeros(double[] nums)
        {
            int position = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[position] = nums[i];
                    position++;
                }
            }

            for(int i = position; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            return nums;
        }

        static bool DivideByAbsMax(double[] array)
        {
            double maxAbsElement = 0;
            bool isDivide = false;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] > maxAbsElement)
                {
                    maxAbsElement = array[i];
                }
                if (array[i] == 0)
                {
                    return false;
                }

                array[i] /= maxAbsElement;
                isDivide = true;
            }
            return isDivide;
        }
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            double[] array = ReadArrayFromFile(path);
            Console.WriteLine(string.Join(" ", array));

            double[] movedZeros = MoveZeros(array);
            Console.WriteLine(string.Join(" ", movedZeros));

            bool devidedByAbsMax = DivideByAbsMax(array);
            Console.WriteLine(devidedByAbsMax);
        }
    }
}
