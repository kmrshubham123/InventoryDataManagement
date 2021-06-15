using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InventoryDataMangement
{
    /// <summary>
    /// Inventory class with Methods GetData().
    /// </summary>
    public class Inventory
    {
        /// <summary>
        /// GetData() method of Inventory class, 
        /// getting data from Json file - consisting of data inventories.
        /// file - DataInventory.json
        /// </summary>
        public void GetData()
        {
            var json = File.ReadAllText(@"D:\BridgeLabz\CSharp\OOP\OOP\InventoryDataMangement\InventoryDataMangement\GroceryList.json");
            var jObject = JObject.Parse(json);
            JArray ListArray = (JArray)jObject["List"];
            try // Block of Code to be tested for error while it is being executed
            {
                if (ListArray != null)
                {
                    Console.WriteLine("Grocery List");
                    Console.WriteLine("==================");
                    foreach (var item in ListArray)
                    {
                        Console.WriteLine($"Product:" + item["Product"]);
                        Console.WriteLine($"Weight(Kg):" + item["Weight"]);
                        Console.WriteLine($"Price per(Kg):" + item["Price"]);
                        ConvertValue(item["Weight"], item["Price"]);
                        Console.WriteLine("====================");
                        
                    }
                }
            }
            catch (Exception ex)// Block of code to be Executed if an error in the block
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void ConvertValue(JToken Weight, JToken Price)// method is use to convert string to double through JToken
        {
            double ConvertingWeight = Weight.ToObject<double>();
            double ConvertingPrice = Price.ToObject<double>();
            double Total = ConvertingWeight*ConvertingPrice; //calculating Total price
            Console.WriteLine("Total:" +Total+"-/rs");
            
        }

    }
}
