using OOPsProblemStatements.InventoryDataManagement;
using OOPsProblemStatements.InventoryManagement;
using OOPsProblemStatements.StockAccountManagement;
using System;
namespace OOPsProoblemStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose option to perform \n1.Inventory Data Management \n2.Inventory Management \n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InventoryOperation operation = new InventoryOperation();
                        operation.ReadJsonFile(@"D:\BridgeLabz\OOPsProblemStatements\OOPsProblemStatements\InventoryDataManagement\Inventory.json");
                        break;
                    case 2:
                        InventoryDataManagement inventory = new InventoryDataManagement();
                        inventory.ReadJsonFile(@"D:\BridgeLabz\OOPsProblemStatements\OOPsProblemStatements\InventoryManagement\InventoryDetails.json");
                        Console.WriteLine("Choose option to perform \n1.Add data \n2.Edit data \n3.Delete data");
                        int opt = Convert.ToInt32(Console.ReadLine());
                        switch (opt)
                        {
                            case 1:
                                inventory.AddInventory();                              
                                break;
                            case 2:
                                inventory.EditInventory();
                                break;
                            case 3:
                                inventory.DeleteInventory();
                                break;
                        }
                        break;                    
                    case 3:
                        flag = false;
                        break;
                }
            }           
        }
    }
}
