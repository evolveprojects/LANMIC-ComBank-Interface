using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using LANMIC_ComBank_Interface.Models.DatabaseModels;
using LANMIC_ComBank_Interface.Models.SageModels;
using log4net;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LANMIC_ComBank_Interface.HelpServices
{ 

    public static class SageApiClient
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static async Task<string> GetListAsync(SageAPICredentials _sageAPICredentials)
        {
            SageResponse res = new SageResponse();

            var apiUrl = "http://" + _sageAPICredentials.URL + "/Sage300WebApi/v1.0/-/" + _sageAPICredentials.Company + "/AP/APVendors";
            var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_sageAPICredentials.Username}:{_sageAPICredentials.Password}"));

            using (var client = new HttpClient())
            {
                // Set headers
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Basic", credentials);

                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                // Send request
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (!response.IsSuccessStatusCode)
                {
                    log.Error("Error calling Sage API: " + response.StatusCode);
                }

                // Read response JSON
                string json = await response.Content.ReadAsStringAsync();
                res = JsonConvert.DeserializeObject<SageResponse>(json);

            }
            return res.Value.Count > 0 ? JsonConvert.SerializeObject(res.Value) : "";
        }

    }
}
