using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LANMIC_ComBank_Interface.Models.SageModels
{
    public class SageResponse
    {
        [JsonPropertyName("@odata.context")]
        public string ODataContext { get; set; }

        //[JsonPropertyName("@odata.nextLink")]
        //public string ODataNextLink { get; set; }

        [JsonPropertyName("value")]
        public List<object> Value { get; set; } = new List<object>();
    }


}
