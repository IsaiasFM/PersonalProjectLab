﻿using System;
using System.Collections.Generic;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int continueProcess = 0;
            List<string> groceryList = new List<string>();
            groceryList.Add("Gocery List");
            int[] itemPrice = new int[1];

            while (continueProcess != 0)
            {
                continueProcess = PrintOptions();

                if (continueProcess == 1)
                {
                    //Adding an item to List
                    Console.WriteLine("Please enter the name of item.");

                    string userInput = Console.ReadLine();

                    groceryList.Add(userInput);

                    Console.WriteLine("Please enter the price of item.");

                    int

                    groceryList.Add(Console.ReadLine());
                }

                else if (continueProcess == 2)
                {
                    // Editing an item in List
                    groceryList.Add(Console.ReadLine());
                }

                else if (continueProcess == 3)
                {
                    // Deleting an item from List
                    groceryList.Add(Console.ReadLine());
                }

                else if (continueProcess == 4)
                {
                    //Printing off List
                    groceryList.Add(Console.ReadLine());
                }

            }
            Console.WriteLine("Thank you! Have a nice day!");
        }

        public static int PrintOptions()
        {
            int chosenOption;
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1 - Add item");
            Console.WriteLine("2 - Edit item");
            Console.WriteLine("3 - Delete item");
            Console.WriteLine("4 - Print List");
            Console.WriteLine("0 - Exit");

            chosenOption = int.Parse(Console.ReadLine());
            return chosenOption;
        }

        public static void Printlist()
        {

        }
    }
}