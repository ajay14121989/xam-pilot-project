using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPilotProject.Models
{
    public class SalesDetail
    {
        [JsonProperty("OrderQty")]
        public int OrderQty { get; set; }

        [JsonProperty("UnitPrice")]
        public int UnitPrice { get; set; }

        [JsonProperty("ProductName")]
        public string ProductName { get; set; }

        [JsonProperty("SalesOrderID")]
        public int SalesOrderID{ get; set; }
    }
}
