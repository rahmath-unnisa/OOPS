using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPS.InventoryDataManagement;

namespace OOPS.InventoryManagent
{
    public class InventoryManager
    {
        InventoryFactory factory = new InventoryFactory();
        List<InventoryData> ListOfRice = new List<InventoryData>();
        List<InventoryData> ListOfPulses = new List<InventoryData>();
        List<InventoryData> ListOfWheat = new List<InventoryData>();
        public void ReadData(string filepath)
        {
            InventoryProgram list = factory.ReadJson(filepath);
            this.ListOfRice = list.ListOfRice;
            this.ListOfPulses = list.ListOfPulses;
            this.ListOfWheat = list.ListOfWheat;
        }
        public void AddInventory(InventoryData data, string inventoryName, string filepath)
        {
            if (inventoryName.Equals("Rice"))
            {
                ListOfRice.Add(data);
            }
            if (inventoryName.Equals("Pulses"))
            {
                ListOfPulses.Add(data);
            }
            if (inventoryName.Equals("Wheat"))
            {
                ListOfWheat.Add(data);
            }

        }
        public void SaveInventory(string filepath)
        {
            InventoryProgram program = new InventoryProgram();
            program.ListOfRice=ListOfRice;
            program.ListOfPulses=ListOfPulses;
            program.ListOfWheat=ListOfWheat;
            factory.WriteToJson(filepath);
        }
        public void EditInventory(string inventoryName,string food,string filepath)
        {
            if(inventoryName.Equals("Rice"))
            {
                foreach (InventoryData data in ListOfRice)
                {
                    if(data.Name.Equals(food))
                    {
                        Console.WriteLine("Selecting Editing Option \n1. Name \n2. Weight \n3. Price Per Kg  \n4.end");
                        int select = Convert.ToInt32(Console.ReadLine());
                        switch (select)
                        {
                            case 1:
                                 data.Name = Console.ReadLine();
                                break;
                            case 2:
                                data.Weight= Convert.ToInt32( Console.ReadLine());
                                break;
                            case 3:
                                data.PricePerKg =Convert.ToInt32( Console.ReadLine());
                                break;
                            case 4:
                                select = 0 ;
                                break;
                        }

                    }
                }
            }
           
            SaveInventory(filepath);
        }

    }
}

