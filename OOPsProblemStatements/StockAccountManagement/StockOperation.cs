using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblemStatements.StockAccountManagement
{
    public class StockOperation
    {
        public void ReadJsonfile(string filePath)
        {
            double Total = 0;
            var data = File.ReadAllText(filePath);
            var result = JsonConvert.DeserializeObject<List<StockDetails>>(data);
            foreach (var inventory in result)
            {               
                Console.WriteLine(inventory.Name + "  " + inventory.NumOfShares + "  " + inventory.SharePrice + "  " + inventory.NumOfShares * inventory.SharePrice);
                Total += inventory.NumOfShares * inventory.SharePrice;
            }                       
            Console.WriteLine("Stock Report: "+Total);
        }
    }
}
