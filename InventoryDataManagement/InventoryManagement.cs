using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OOPS.InventoryDataManagement
{
    public class InventoryManagement
    {
        public void DisplayInventory(string filepath)
        {
            using (StreamReader reader = new StreamReader(filepath))
            {
                var json = reader.ReadToEnd();
                var inventory = JsonConvert.DeserializeObject<List<InventoryData>>(json);
                Console.WriteLine("Name" + "\t " + "Weight" + "\t\t" + "PricePerKg" + "\t" + "TotalPrice");
                foreach(var data in inventory)
                {
                    Console.WriteLine(data.Name + "\t" + data.Weight + "\t\t" + data.PricePerKg + " \t\t" +( data.Weight*data.PricePerKg));
                }
                  
            }
        }
    }
}
