using System;
using System.Collections.Generic;
using System.IO;

namespace Week9
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingList();
            CreateFileLocation();
           
        }
        public static void CreateFileLocation()
        {
            string rootDirectory = @"C:\Users\Public\samples";

            Console.WriteLine("Enter directory name:");
            string newDirectory = Console.ReadLine();

            Console.WriteLine("Enter fire name:");
            string fileName = Console.ReadLine();

            Directory.CreateDirectory($"{ rootDirectory}\\{newDirectory}");
            File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
        }
        public static void ShoppingList()
        {
            List<string> myShoppingList = new List<string>();

            Console.WriteLine("What would you like to add to the list?");
            myShoppingList.Add(Console.ReadLine());

            Console.WriteLine("Would you like to continue? [Y/N]");

            for (int i = 1; i > 0; i++)
            {
                if (Console.ReadLine() == "Y")
                {
                    Console.WriteLine("What would you like to add to the list?");
                    myShoppingList.Add(Console.ReadLine());
                    Console.WriteLine("Would you like to continue? [Y/N]");
                }
                else if (Console.ReadLine() == "N")
                {
                    Console.WriteLine("Good, have a good day!");
                    i = 0;
                }
            }
        }
    }
}
