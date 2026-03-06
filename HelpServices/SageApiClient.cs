using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using LANMIC_ComBank_Interface.Config;
using LANMIC_ComBank_Interface.Data;
using LANMIC_ComBank_Interface.Models.DatabaseModels;
using LANMIC_ComBank_Interface.Models.SageModels;
using LANMIC_ComBank_Interface.Models.SystemModels;
using log4net;
using Newtonsoft.Json;

namespace LANMIC_ComBank_Interface.HelpServices
{

    public static class SageApiClient
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly AppDbContext db = new AppDbContext(AppConfigService.ConnectionString());
        public static async Task<string> GetListAsync(string ApiEndPoint)
        {
            SageAPICredentials _sageAPICredentials = db.SageAPICredentials.FirstOrDefault();
            if (_sageAPICredentials == null)
            {
                log.Error("Failed to load Sage API credentials.");
                return string.Empty;
            }
            else
            {
                SageResponse res = new SageResponse();

                var apiUrl = $"http://{_sageAPICredentials.Domain}/Sage300WebApi/{_sageAPICredentials.ApiVersion}/{_sageAPICredentials.Tenant}/{_sageAPICredentials.Company}/{ApiEndPoint.Substring(0, 2)}/{ApiEndPoint}";
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
}
