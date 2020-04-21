using System;
using System.Collections.Generic;

namespace PersonalProjectLab
{
    public class MyGroceryList
    {
        string _Name;
        List<string> groceryList = new List<string>();
        List<decimal> itemPrice = new List<decimal>();

        public MyGroceryList()
        {
            _Name = "unknown";
        }

        public void PersonName(string name)
        {
            _Name = name;
        }

        public void AddToList(string item, decimal price)
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
            Console.WriteLine(_Name + "'s List");

            for (int i = 0; i < groceryList.Count; i++)
            {
                int j = i + 1;
                Console.WriteLine(j + ". " + groceryList[i] + " $" + itemPrice[i]);
            }
        }

        public decimal TotalPrice()
        {
            decimal totalPrice = 0;

            for (int i = 0; i < itemPrice.Count; i++)
            {
                totalPrice += itemPrice[i];
            }

            return totalPrice;
        }
    }
}
