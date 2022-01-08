using System;
using System.Collections.Generic;

namespace CSharp_Second_Semester
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ZahlenTestListe = GetListOfRandomIntegers(10);
            Console.WriteLine("Summe:" + SumOfList(ZahlenTestListe));
            Console.WriteLine("Average:" + AverageOfList(ZahlenTestListe));
            Console.WriteLine("Average2:" + AverageOfList2(ZahlenTestListe));
            TwoListsSorted(ZahlenTestListe);
            //PrintList(SortedList(ZahlenTestListe));
            //PrintList(ZahlenTestListe);
            

        }

        public static void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void PrintLists(List<int> list, List<int> list1)
        {
            Console.Write("Even Numbers: ");
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.Write("Uneven Numbers: ");
            foreach (int item in list1)
            {
                Console.Write(item + " ");
            }
        }
        public static double AverageOfList(List<int> list)
        {
            long result = 0;
            foreach (int item in list)
            {
                result += item;
            }
            return result / list.Count;
        }
        public static double AverageOfList2(List<int> list)
        {

            return SumOfList(list) / list.Count;
        }

        public static List<int> SortedList(List<int> list)
        {
            int biggerValue;
            bool didSwap;
            int numberOfRuns = 0;

            do
            {
                didSwap = false;
                numberOfRuns++;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        biggerValue = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = biggerValue;
                        didSwap = true;
                    }
                }
            } while (didSwap);

            return list;
            
        }
        public static int SumOfList(List<int> list)
        {
            int result = 0;
            foreach (int item in list)
            {
                result += item;
            }
            return result;
        }
        public static List<int> GetListOfRandomIntegers(int size)
        {
            List<int> resultList = new List<int>();
            Random randomGenerator = new Random();

            for (int i = 0; i < size; i++)
            {
                int randomNumber = randomGenerator.Next(0, 5000);
                resultList.Add(randomNumber);
            }
            return resultList;
        }

        public static void TwoListsSorted(List<int> list)
        {

            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            foreach (var item in list)
            {
                if (item % 2 == 0)
                {
                    list1.Add(item);
                } else
                {
                    list2.Add(item);
                }
            }
            //(List<int>, List<int>) lists = (list1, list2);
            //var tuple = new Tuple<List<int>, List<int>>(list1, list2);
            PrintLists(list1, list2);
        }
    }
}
