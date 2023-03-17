﻿using OOPsProblemStatements.InventoryDataManagement;
using OOPsProblemStatements.InventoryManagement;
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
                Console.WriteLine("Choose option to perform \n1.Inventory Data Management \n2.Inventory Management \n3.Add Inventory \n4.Exit");
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
                        break;
                    case 3:
                        InventoryDataManagement inventory1 = new InventoryDataManagement();
                        inventory1.DeleteInventory();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }           
        }
    }
}
