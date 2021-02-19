using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPilotProject.Models
{
    public class SalesListItem
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("Detail")]
        public SalesDetail Detail { get; set; }

        [JsonProperty("Customer")]
        public string Customer { get; set; }
        [JsonProperty("OrderDate")]
        public string OrderDate { get; set; }

        [JsonProperty("SalesOrder")]
        public string SalesOrder { get; set; }

        [JsonProperty("SalesPerson")]
        public string SalesPerson { get; set; }

        [JsonProperty("TotalAmount")]
        public int TotalAmount { get; set; }
    }
}
