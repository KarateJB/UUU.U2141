using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U2141.Practice.Domain;
using static System.Console;

namespace U2141.Practice
{
    
    internal delegate int CalculateDelegate(int a, int b);

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
            //hashTableSample();

            //Generic
            //genericCollectionSample();

            //Function with dynamic parameters
            //int sum = dynamicParamsSample(10,20,30);
            //Console.WriteLine($"Sum={sum}");


            //Decimal formatting
            //decimalFormatSample();

            //Struct
            //BookStruct book1;
            //book1.Name = "C# is amazing!!";
            //book1.Price = 100;
            //BookStruct book2 = book1;
            //book1.Name = "Angular is amazing!!";
            //book1.Price = 200;

            //Console.WriteLine($"{book1.Name} : {book1.Price}");
            //Console.WriteLine($"{book2.Name} : {book2.Price}");

            //Static property
            //StaticBook js = new StaticBook() { Name = "JS" };
            //Console.WriteLine($"{js.ToString()}");
            //StaticBook cSharp = new StaticBook() { Name = "C#" };
            //Console.WriteLine($"{cSharp.ToString()}");
            //StaticBook angular = new StaticBook() { Name = "Angular" };
            //Console.WriteLine($"{angular.ToString()}");

            //Delegate
            CalculateDelegate calculate = Calculator.Add;
            calculate += Calculator.Minus;
            calculate += Calculator.Divide;
            calculate += Calculator.Multiplicate;

            var result = calculate(5, 6);
            Console.WriteLine($"{result}");



            //C# 7.0 : Nested function
            //Console.WriteLine(getTitle("JB", "Lin"));
            //string getTitle(string firstName, string lastName) => $"{lastName} {firstName}";

            //C# 7.0 : Out variable
            //getTitleByOut(out string myTitle);
            //Console.WriteLine($"Title = {myTitle}");

            //C# 7.0 : Ref returns
            //string[] names = new string[] { "JB", "Lin", string.Empty };
            //string msg = "Hello! ";
            //ref string data = ref new Program().getNameByRef(names, msg);
            //Console.WriteLine($"{msg}, {names[2]}");
            //Console.WriteLine($"{data}");




            Console.ReadKey();
        }

        private static void decimalFormatSample()
        {
            decimal d1 = 10000.5m;
            d1 = 10_000.5m; //For readable
            Console.WriteLine($"{d1.ToString("c")}"); //To cash 

            d1 = d1 / 100;
            Console.WriteLine($"{(d1/100).ToString("p")}"); //To percentage
            Console.WriteLine($"{(d1/100).ToString("##.##%")}"); //To percentage
        }

        private static int dynamicParamsSample(params int[] values)
        {
            int result = 0;
            for (int i = 0; i < values.Length; i++)
            {
                result += values[i];
                
            }
            return result;

        }

        private ref string getNameByRef(string[] name, string msg)
        {
            msg = "Bravo!";
            name[2] = $"{name[1]} {name[0]}";
            return ref name[2];
        }

        private static void getTitleByOut(out string title)
        {
            title = "My new title....";
        }

        private static void genericCollectionSample()
        {
            #region Method 1.
            //var movies = new System.Collections.Generic.Dictionary<string,string>();
            //movies.Add("07:00", "Good morning!");
            //movies.Add("15:00", "Good afternoon!");
            //movies.Add("21:00", "Good nite!");
            #endregion

            #region Method 2.
            //var movies = new System.Collections.Generic.Dictionary<string, string>()
            //{
            //    { "07:00", "Good morning!" },
            //    { "15:00", "Good afternoon!" },
            //    { "21:00", "Good nite!" }
            //};
            #endregion

            #region Method 3.
            var movies = new System.Collections.Generic.Dictionary<string, string>()
            {
                ["07:00"] = "Good morning!",
                ["15:00"] = "Good afternoon!",
                ["21:00"] = "Good nite!",
            };
            #endregion


            Console.WriteLine(movies["21:00"]);
        }

        private static void hashTableSample()
        {
            System.Collections.Hashtable movies = new System.Collections.Hashtable();
            movies.Add("07:00", "Good morning!");
            movies.Add("15:00", "Good afternoon!");
            movies.Add("21:00", "Good nite!");
            Console.WriteLine(movies["21:00"]);
        }

        private static void arrayListSample()
        {
            ArrayList list = new ArrayList();
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
