using System;
namespace PersonalProjectLab
{
    class Program
    {

        static void Main(string[] args)
        {
            MyShoppingList myList = new MyShoppingList();
            int continueProcess = 1;
            string stringInput;
            decimal intInput;


            Console.WriteLine("Hello! What is your name?");
            stringInput = Console.ReadLine();
            myList.PersonName(stringInput);

            while (continueProcess != 0)
            {
                continueProcess = PrintOptions();
                Console.WriteLine();

                if (continueProcess == 1)
                {
                    //Adding an item to List
                    Console.WriteLine("Please enter the name of item.");
                    stringInput = Console.ReadLine();
                    stringInput = char.ToUpper(stringInput[0]) + stringInput.Substring(1);

                    Console.WriteLine("Please enter the price of item.");
                    intInput = decimal.Parse(Console.ReadLine());

                    myList.AddToList(stringInput, intInput);
                }
         
                else if (continueProcess == 2)
                {
                    // Deleting an item from List
                    Console.WriteLine("Please enter the item number you would like to delete?");

                    myList.PrintList();

                    int userChoice = int.Parse(Console.ReadLine());

                    myList.DeleteFromList(userChoice);
                }

                else if (continueProcess == 3)
                {
                    //Printing off List with total price
                    myList.PrintList();

                    Console.WriteLine("Total Price: $" + myList.TotalPrice());
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
            Console.WriteLine("2 - Delete item");
            Console.WriteLine("3 - Print List");
            Console.WriteLine("0 - Exit");

            chosenOption = int.Parse(Console.ReadLine());
            return chosenOption;
        }
    }
}