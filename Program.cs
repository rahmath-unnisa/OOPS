using System;
using OOPS.InventoryDataManagement;
namespace OOPS
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Welcome To Inventory Management----------------");
            const string Inventory_File_Path = @"D:\Practice Problems\OOPS\OOPS\InventoryDataManagement\Inventory.json";
            InventoryManagement data = new InventoryManagement();
            Console.WriteLine("Display ");
            bool end = true;
            while(end)
            {
                Console.WriteLine("Enter The Option To Display");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        data.DisplayInventory(Inventory_File_Path);
                        break;
                    case 2:
                        end = false;
                        break;


                }
            }
        }

    }
}
