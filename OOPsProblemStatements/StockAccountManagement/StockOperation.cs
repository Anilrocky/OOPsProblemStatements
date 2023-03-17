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
            var data = File.ReadAllText(filePath);
            var result = JsonConvert.DeserializeObject<List<StockDetails>>(data);
            double Total = 0;
            foreach (var inventory in result)
            {
                Console.WriteLine(inventory.Name + "    " + inventory.Share + "  " + inventory.SharePrice + "  " + inventory.Share * inventory.SharePrice);
                Total += (inventory.Share * inventory.SharePrice);
            }
            Console.WriteLine("Stock value: " + Total);
        }
    }
}
