using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int continueProcess = 0;
            List<string> groceryList = new List<string>();

            while (continueProcess != 0)
            {
                continueProcess = PrintOptions();

                if (continueProcess == 1)
                {
                    groceryList.Add(Console.ReadLine());
                }

                else if (continueProcess == 2)
                {

                }

                else if (continueProcess == 3)
                {

                }

                else if (continueProcess == 4)
                {

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