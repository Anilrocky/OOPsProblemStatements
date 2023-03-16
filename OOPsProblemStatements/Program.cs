using OOPsProblemStatements.InventoryDataManagement;
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
                Console.WriteLine("Choose option to perform \n1.Inventory Data Management \n2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InventoryOperation operation = new InventoryOperation();
                        operation.ReadJsonFile(@"D:\BridgeLabz\OOPsProblemStatements\OOPsProblemStatements\InventoryDataManagement\Inventory.json");
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }           
        }
    }
}
