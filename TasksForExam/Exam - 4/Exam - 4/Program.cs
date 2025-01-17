﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam___4
{
    internal class Program
    {
        static int[] ReadArrayFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string[] array = lines[0].Split('\t');

            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = int.Parse(array[i]);  
            }

            return newArray;
        }

        static int LargestNegative(int[] array)
        {
            int maxNegative = 0;
            foreach(int i in array)
            {
                if(i < 0 && (maxNegative == 0 || i > maxNegative))
                {
                    maxNegative = i;
                }
            }
            return maxNegative;
        }

        static int[] RotateRigth(int[] array)
        {
            int lastElement = array[array.Length - 1];

            for(int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = lastElement;

            return array;   
        }

        
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            int[] array = ReadArrayFromFile(path);
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine(LargestNegative(array));
            Console.WriteLine(string.Join(" ", RotateRigth(array)));
        }
    }
}
