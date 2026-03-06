using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using LANMIC_ComBank_Interface.Models.CombankModels;
using Newtonsoft.Json;

namespace LANMIC_ComBank_Interface.HelpServices.CombankAPI
{
    public static  class SendPaymentRequest
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> SendPaymentAsync(PaymentRequest payment)
        {
            // Get valid access token
            string token = await TokenManager.GetValidAccessTokenAsync();

            // Set Bearer token
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            string apiUrl = "https://apps-uat.combank.net/payment/e2gen/bulk";

            // Convert payment object to JSON
            var json = JsonConvert.SerializeObject(payment);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(apiUrl, content);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Payment API Error: {error}");
            }
            var responseJson = await response.Content.ReadAsStringAsync();
            var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(responseJson);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
