using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Modules.Models.Requests
{
    public class InsertUpdateCompanyRequestModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("taxNumber ")]
        public string TaxNumber { get; set; }
    }
}
