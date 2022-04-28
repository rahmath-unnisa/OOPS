using System;
using OOPS.InventoryDataManagement;
using OOPS.InventoryManagent;
using OOPS.StockManagement;

namespace OOPS
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Welcome To Inventory Management----------------");
            const string Inventory_File_Path = @"D:\Practice Problems\OOPS\OOPS\OOPS\InventoryDataManagement\Inventory.json";
            const string Inventory_Path = @"D:\Practice Problems\OOPS\OOPS\OOPS\InventoryManagent\InventoryList.json";
            const string stock_path = @"D:\Practice Problems\OOPS\OOPS\OOPS\StockManagement\Stock.json";
            Console.WriteLine("1.Display Inventory \n2.AddInventory \n3.Save Inventory \n4.Edit Inventory \n5. Display Stock \n6. End Of The Program");
            InventoryManagement inventoryManagement = new InventoryManagement();
            InventoryManager manager = new InventoryManager();
            InventoryData data= new InventoryData();
            StockDataManagement stocks = new StockDataManagement();
            Console.WriteLine("Display ");
            bool end = true;
            while(end)
            {
                Console.WriteLine("Enter The Option To Display");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        inventoryManagement.DisplayInventory(Inventory_File_Path);
                        break;
                    case 2:
                        Console.WriteLine("Enter the data and the list ");
                        string inventoryName=Console.ReadLine();
                        Console.WriteLine("Enter inventory details");
                        data.Name = Console.ReadLine();
                        data.Weight = Convert.ToInt32(Console.ReadLine());
                        data.PricePerKg = Convert.ToInt32( Console.ReadLine());
                        manager.AddInventory(data,inventoryName,Inventory_Path);
                        break ;
                    case 3:
                        manager.SaveInventory(Inventory_Path);
                        break ;
                    case 4:
                        Console.WriteLine("Enter the data and the list ");
                        string inventoryNames = Console.ReadLine();
                        string foods = Console.ReadLine();
                        manager.EditInventory(inventoryNames, foods, Inventory_Path);
                        break;
                    case 5:
                        stocks.DisplayStock(stock_path);
                        break;
                    case 6:
                        end = false;
                        break;
                }
            }
        }

    }
}
