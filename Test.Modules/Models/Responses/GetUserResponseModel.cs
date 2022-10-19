using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Modules.Models.Responses
{
    public class GetUserResponseModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("pass")]
        public string Pass { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
