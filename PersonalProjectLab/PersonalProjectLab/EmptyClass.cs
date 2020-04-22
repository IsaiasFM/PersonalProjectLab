using System;
using System.Collections.Generic;

namespace PersonalProjectLab
{
    public class MyShoppingList
    {
        string _Name;
        List<string> ShoppingList = new List<string>();
        List<decimal> itemPrice = new List<decimal>();

        public MyShoppingList()
        {
            _Name = "unknown";
        }

        public void PersonName(string name)
        {
            _Name = name;
        }

        public void AddToList(string item, decimal price)
        {
            ShoppingList.Add(item);
            itemPrice.Add(price);
        }

        public void DeleteFromList(int number)
        {
            number -= 1;
            ShoppingList.RemoveAt(number);
            itemPrice.RemoveAt(number);
        }

        public void PrintList()
        {
            Console.WriteLine(_Name + "'s List");

            for (int i = 0; i < ShoppingList.Count; i++)
            {
                int j = i + 1;
                Console.WriteLine(j + ". " + ShoppingList[i] + " $" + itemPrice[i]);
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
