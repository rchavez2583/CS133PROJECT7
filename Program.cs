using System;
using System.Collections.Generic;
using System.Linq;

namespace CS133PROJECT7
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageInventory Inventory = new ManageInventory();


           
            Inventory.AddRackToTheInventory("ABC123");
            Inventory.AddRackToTheInventory("ABC234");
            Inventory.AddRackToTheInventory("ABS321");
            Inventory.AddRackToTheInventory("ABC675");
            Inventory.AddRackToTheInventory("ABC098");
            Inventory.AddRackToTheInventory("ABC632");
            Inventory.AddRackToTheInventory("ABC711");
            Inventory.AddRackToTheInventory("ABC899");
            Inventory.AddRackToTheInventory("ABS233");
            Inventory.AddRackToTheInventory("ABS621");
            Inventory.AddRackToTheInventory("DEF221");
            Inventory.AddRackToTheInventory("DEF321");
            Inventory.AddRackToTheInventory("DEF675");
            Inventory.AddRackToTheInventory("DEF098");
            Inventory.AddRackToTheInventory("DEF632");
            Inventory.AddRackToTheInventory("DEF711");
            Inventory.AddRackToTheInventory("DEF899");
            Inventory.AddRackToTheInventory("DEF233");
            Inventory.AddRackToTheInventory("DEF667");
            Inventory.AddRackToTheInventory("DEF990");
            




            Inventory.AddRackToTheInventory();

            Inventory.ShowMeTheRacksNotAvailable();
        }
    }
}

public class ManageInventory
{
    Queue<string> Inventory = new Queue<string>();

    Dictionary<int, TypeCode> MyInventory = new Dictionary<int, TypeCode>();
   
    public void AddRackToTheInventory(string Code)
    {
        Inventory.Enqueue(Code);

        int count = Inventory.Count;

        bool doesItAvailable  = Inventory.Contains(Code);

        if (!doesItAvailable)

        {
            Inventory.Contains(Code);
          
        }

    }

    public void ShowMeTheRacksNotAvailable()
    {
      
        {
            Console.WriteLine("The inventory has these many racks full: " + Inventory.Count);
            foreach(var Code in Inventory)
            {
                Console.WriteLine("{0} has a rack number of: {1}",
                                 Inventory.Value.Number,
                                 Inventory.Value.Code);
            }
        }
    }

}

public class Tycode
{
    public string Number {get; set;}
    public string Code { get; set; }
}


