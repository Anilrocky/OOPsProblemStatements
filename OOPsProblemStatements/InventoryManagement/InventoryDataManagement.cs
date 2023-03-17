using Newtonsoft.Json;
using OOPsProblemStatements.InventoryDataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblemStatements.InventoryManagement
{
    public class InventoryDataManagement
    {
        List<InventoryData> riceList;
        List<InventoryData> pulsesList;
        List<InventoryData> wheatList;
        public void ReadJsonFile(string filePath)
        {
            var data = File.ReadAllText(filePath);
            var result = JsonConvert.DeserializeObject<InventoryList>(data);
            riceList = result.RiceList;
            Display(riceList);
            pulsesList = result.PulsesList;
            Display(pulsesList);
            wheatList = result.WheatList;
            Display(wheatList);
        }
        public void Display(List<InventoryData> list)
        {
            foreach (var inventory in list)
            {
                Console.WriteLine(inventory.Name + "\t" + inventory.Weight + "\t" + inventory.PricePerKg + "\t" + inventory.Weight * inventory.PricePerKg);
            }
        }
        public void AddInventory()
        {            
            Console.WriteLine("Enter in which list new inventory need to be added");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Inventory data");
            InventoryData data = new InventoryData();
            data.Name = Console.ReadLine();
            data.Weight = Convert.ToDouble(Console.ReadLine());
            data.PricePerKg = Convert.ToDouble(Console.ReadLine());
            if (name.ToLower().Equals("rice"))
            {
                riceList.Add(data);
                Display(riceList);
            }
            if (name.ToLower().Equals("pulses"))
            {
                pulsesList.Add(data);
                Display (pulsesList);
            }
            if (name.ToLower().Equals("wheat"))
            {
                wheatList.Add(data);
                Display (wheatList);
            }
        }
        public void EditInventory()
        {
            Console.WriteLine("Enter in which list inventory need to be edited");
            string name = Console.ReadLine();
            if (name.ToLower().Equals("rice"))
            {
                foreach (var data in riceList)
                {
                    Console.WriteLine("Enter Name");
                    data.Name = Console.ReadLine();
                    Console.WriteLine("Enter Weight");
                    data.Weight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter PricePerKg");
                    data.PricePerKg = Convert.ToDouble(Console.ReadLine());
                }
                Display(riceList);
            }
            if (name.ToLower().Equals("pulses"))
            {
                foreach (var data in pulsesList)
                {
                    Console.WriteLine("Enter Name");
                    data.Name = Console.ReadLine();
                    Console.WriteLine("Enter Weight");
                    data.Weight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter PricePerKg");
                    data.PricePerKg = Convert.ToDouble(Console.ReadLine());
                }
                Display(pulsesList);
            }
            if (name.ToLower().Equals("wheat"))
            {
                foreach (var data in wheatList)
                {
                    Console.WriteLine("Enter Name");
                    data.Name = Console.ReadLine();
                    Console.WriteLine("Enter Weight");
                    data.Weight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter PricePerKg");
                    data.PricePerKg = Convert.ToDouble(Console.ReadLine());
                }
                Display(wheatList);
            }
        }
        public void DeleteInventory()
        {
            InventoryData data = new InventoryData();
            Console.WriteLine("Enter in which list inventory need to be deleted");
            string name = Console.ReadLine();
            if (name.ToLower().Equals("rice"))
            {
                riceList.Remove(data);
                Display(riceList);
            }
            if (name.ToLower().Equals("pulses"))
            {
                pulsesList.Remove(data);
                Display(pulsesList);
            }
            if (name.ToLower().Equals("wheat"))
            {
                wheatList.Remove(data);
                Display(wheatList);
            }
        }
    }
}