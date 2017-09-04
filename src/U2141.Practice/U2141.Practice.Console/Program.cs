using System;
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
            copyArray();


            //Jagged array
            jaggedArray();

            Console.ReadKey();
        }

        
        private static void copyArray()
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

        private static void jaggedArray()
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
