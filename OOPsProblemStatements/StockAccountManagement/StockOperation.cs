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
            foreach (var inventory in result)
            {
                Console.WriteLine(inventory.Name + "    " + inventory.Share + "  " + inventory.SharePrice + "  " + inventory.Share * inventory.SharePrice);
            }
        }
    }
}
