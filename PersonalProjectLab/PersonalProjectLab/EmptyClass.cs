using System;
using System.Collections.Generic;

namespace PersonalProjectLab
{
    public class MyGroceryList
    {
        string Name;
        List<string> groceryList = new List<string>();
        List<int> itemPrice = new List<int>();

        public MyGroceryList()
        {
            Name = "unknown";
        }

        public void PersonName(string name)
        {
            Name = name;
        }

        public void AddToList(string item, int price)
        {
            groceryList.Add(item);
            itemPrice.Add(price);
        }

        public void DeleteFromList(int number)
        {
            number -= 1;
            groceryList.RemoveAt(number);
            itemPrice.RemoveAt(number);
        }

        public void PrintList()
        {
            for (int i = 0; i < groceryList.Count; i++)
            {
                int j = i + 1;
                Console.WriteLine(j + ". " + groceryList[i] + " " + itemPrice[i]);
            }
        }


    }
}
