using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2141.Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array copy
            //copyArraySample();

            //Jagged array
            //jaggedArraySample();

            //ArrayList
            //arrayListSample();

            //HashTable
            hashTableSample();



            Console.ReadKey();
        }

        private static void hashTableSample()
        {
            System.Collections.Hashtable movies = new System.Collections.Hashtable();
            movies.Add("10:00", "神力男超人");
            movies.Add("13:00", "薑餅人：回家日");
            movies.Add("16:00", "名偵探阿北");
            Console.WriteLine(movies["13:00"]);
        }

        private static void arrayListSample()
        {
            ArrayList list= new ArrayList();
            list.Add(100);
            list.Add("demo");
            list.Add(DateTime.Now);
            Console.WriteLine((int)list[0] + 200);
            Console.WriteLine(list[1]);
            Console.WriteLine(((DateTime)list[2]).ToShortDateString());
            //================================
            int i = 100;
            object obj = i;//int->object, boxing
            int j = (int)obj; //object->int, unboxing
            Console.WriteLine(j + 200);
        }

        private static void copyArraySample()
        {
            int[] list = new int[5] { 1, 2, 3, 4, 5 };
            int[] newList = new int[10];
            Array.Copy(list, newList, list.Length);
            list = newList; //Assign to the new memory address 

            for (var i = 0; i < newList.Length; i++)
            {
                System.Console.WriteLine($"Current value = {i}");
            }
        }

        private static void jaggedArraySample()
        {
            string[][] year = new string[12][];
            year[0] = new string[31];
            year[1] = new string[28];
            year[2] = new string[31];

            year[0][1] = "Mon.";
            year[0][2] = "Tue.";
            year[0][3] = "Wed.";

        }
    }
}
