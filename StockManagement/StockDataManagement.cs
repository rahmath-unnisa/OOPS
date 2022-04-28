using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OOPS.StockManagement
{
    public class StockDataManagement
    {
        public void DisplayStock(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                var stocks = JsonConvert.DeserializeObject<List<StockData>>(json);
                Console.WriteLine("StockName" + "\t" + "NumOfShare" + "\t" + "SharePrice" + "\t" + "TotalPrice");
                foreach (var data in stocks)
                {
                    Console.WriteLine(data.StockName + "\t\t" + data.NumberOfShares + "\t\t" + data.SharePrice + "\t\t" + (data.NumberOfShares * data.SharePrice));
                }
            }
        }
    }
}
