using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPilotProject.Models
{
    public class SalesListResponse
    {
        [JsonProperty("data")]
        public List<SalesListItem> data { get; set; }
    }
}
