using System;
using System.Collections.Generic;

namespace PersonalProjectLab
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> groceryList = new List<string>();
            List<int> ItemPrice = new List<int>();
            int continueProcess = 1;

            while (continueProcess != 0)
            {
                continueProcess = PrintOptions();
                Console.WriteLine();

                if (continueProcess == 1)
                {
                    //Adding an item to List
                    Console.WriteLine("Please enter the name of item.");
                    string userInput = Console.ReadLine();

                    groceryList.Add(userInput);

                    Console.WriteLine("Please enter the price of item.");
                    int Price = int.Parse(Console.ReadLine());

                    ItemPrice.Add(Price);
                }

                else if (continueProcess == 2)
                {
                    // Editing an item in List
                    for (int i = 0; i < groceryList.Count; i++)
                    {
                        int j = 1 + i;

                        Console.WriteLine(j + ". " + groceryList[i]);
                    }

                    Console.WriteLine("Which item would you like to edit? Please enter number.");
                    int itemChoice = int.Parse(Console.ReadLine());

                    Console.WriteLine("Rename Item? 1 - Yes, 2 - No");

                    int userInput = int.Parse(Console.ReadLine());
                    

                    if (userInput == 1)
                    {
                        Console.WriteLine("Please enter the name of item.");
                        string itemName = Console.ReadLine();

                        groceryList.(itemName);
                    }
                }

                else if (continueProcess == 3)
                {
                    // Deleting an item from List
                    groceryList.Add(Console.ReadLine());
                }

                else if (continueProcess == 4)
                {
                    //Printing off List

                    Console.WriteLine("Grocery List");
                    Console.WriteLine();

                    for (int i = 0; i < groceryList.Count; i++)
                    {
                        Console.WriteLine(groceryList[i] + " $" + ItemPrice[i]);
                    }
                }
                Console.WriteLine();
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
    }
}