using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OOPS.InventoryDataManagement;

namespace OOPS.InventoryManagent
{
    public class InventoryFactory
    {
        public InventoryProgram ReadJson(string filepath)
        {
            using (StreamReader reader = new StreamReader(filepath))
            {
                var json = reader.ReadToEnd();
                var inventory = JsonConvert.DeserializeObject<InventoryProgram>(json);
                return inventory;
               
            }
        }
        public InventoryProgram WriteToJson(string filepath)
        {
            using (StreamReader reader = new StreamReader(filepath))
            {
                var json = reader.ReadToEnd();
                var inventory = JsonConvert.DeserializeObject<InventoryProgram>(json);
                return inventory;

            }

        }

    }
}