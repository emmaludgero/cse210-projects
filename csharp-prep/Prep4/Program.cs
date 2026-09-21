using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> shoppingList = new List<string>();
        shoppingList.Add("Strawberry");
        shoppingList.Add("Milk");

        foreach (string food in shoppingList)
        {
            Console.WriteLine(food);
        }
        
    }
}