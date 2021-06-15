using System;

namespace InventoryDataMangement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Welcome To Inventory Management Program====");
            Inventory inventory = new Inventory();
            inventory.GetData();


        }
    }
}
