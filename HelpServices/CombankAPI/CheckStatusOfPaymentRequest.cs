using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace LANMIC_ComBank_Interface.HelpServices.CombankAPI
{
    public static class CheckStatusOfPaymentRequest
    { 
        private static readonly HttpClient client = new HttpClient();
        public static async Task<string> CheckStatusAsync(string company, string cbcref)
        {
            var body = new Dictionary<string, string>
                                                     {
                                                         { "COMPANY", company },
                                                         { "CBCREF", cbcref }
                                                     };

            // Get valid access token
            string token = await TokenManager.GetValidAccessTokenAsync();

            // Set Bearer token
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            string apiUrl = $"https://apps-uat.combank.net/payment/e2gen/status";

            // Convert payment object to JSON
            var json = JsonConvert.SerializeObject(body);

            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(apiUrl, content);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Status API Error: {error}");
            }

            var responseJson = await response.Content.ReadAsStringAsync();
            var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(responseJson);

            return await response.Content.ReadAsStringAsync();
        }           
    }
}
