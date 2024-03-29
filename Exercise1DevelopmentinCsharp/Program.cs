﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1DevelopmentinCsharp
{
        class MainClass
    {
        // Compare 2 words
        public string CompareTwoStrings(string word1, string word2)
        {
            try
            {
                return word1.Equals(word2) ? "These two words are equal" : "These 2 words are not equal";

            }
            catch (NullReferenceException)
            {
                return "You can't compare null objects";
            }
        }

        // Verify the biggest number in a list
        public bool SortArray(int[] a)
        {

            int temp;

            for (int i = 0; i < a.Length; i++)
            {

                for (int j = 0; j < a.Length - 1; j++)
                {

                    if (a[j] > a[j + 1])
                    { 

                        temp = a[j + 1];

                        a[j + 1] = a[j];

                        a[j] = temp;
                    }
                }
            }

            // Find max value
            int max = a[0];

            for (int i = 0; i < a.Length; i++)
            {

                if (max < a[i])
                {

                    max = a[i];
                }
            }
            Console.WriteLine("The biggest number in the array is: " + max); // print max value

            // Compare largest number with max value
            if (a[a.Length - 1] == max)
            {
                return true;
            }
            return false;
        }


        // Sort a list of Strings by Ascending and Descending order
        public void SortStrings(string[] x)
        {
            string temp;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (string.Compare(x[i], x[j], StringComparison.CurrentCulture) > 0) // > Used for ascending order
                    {
                        temp = x[i];

                        x[i] = x[j];

                        x[j] = temp;

                    }
                }
            }
            Console.WriteLine("Ascending order will be: " + string.Join(", ", x));

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (string.Compare(x[i], x[j], StringComparison.CurrentCulture) < 0) // < used for descending order 
                    {
                        temp = x[i];

                        x[i] = x[j];

                        x[j] = temp;

                    }
                }
            }
            Console.WriteLine("Descending order will be: " + string.Join(", ", x));

        }

        public int ReturnLengthofString(string b)
        {

            int j = 0;

            for (int i = 0; i < b.Length; i++)
            {
                _ = b[i];
                j++;
            }
            Console.Write("The length of the string is: ");
            return j;
        }


        public void FirstFiveValues(List<int> l)
        {
            int j = 0;

            for (int i = 0; i < 5; i++)
            {
                _ = l[i];

                j++;

                Console.WriteLine(j);
                //Console.WriteLine(string.Join(", ", j));
            }
        }










        public static void Main(string[] args)
        {
            MainClass compare = new MainClass();
            Console.WriteLine(compare.CompareTwoStrings(null, null));

            MainClass sort = new MainClass();
            int[] a = { 3, 2, 44, 35 };
            Console.WriteLine(sort.SortArray(a));

            MainClass sortAscDesc = new MainClass();
            string[] o = new string [4] { "Hello", "Airplane", "Car", "Zebra" };
            sortAscDesc.SortStrings(o);

            MainClass count = new MainClass();
            Console.WriteLine(count.ReturnLengthofString("holatepicolacola"));

            MainClass values = new MainClass();
            List<int> intList = new List<int>
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8
            };
            values.FirstFiveValues(intList);




        }
    }
}
