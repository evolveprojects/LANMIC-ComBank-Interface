using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LANMIC_ComBank_Interface.Models.CombankModels;
using log4net;
using Newtonsoft.Json;

namespace LANMIC_ComBank_Interface.HelpServices.CombankAPI
{
    public static class TokenManager
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static APIToken _token;

        private static DateTime _accessTokenExpiry;
        private static DateTime _refreshTokenExpiry;

       private static string tokenUrl = "https://apps-uat.combank.net/auth/realms/Combank/protocol/openid-connect/token";
       private static string clientId = "payment-service";
       private static string clientSecret = "de2c59d3-b896-4a63-9afe-5e7b04bb5c54";
       private static string username = "1000478594";
       private static string password = "qaz!QAZ";
       private static string scope = "openid profile";

        public static async Task<string> GetValidAccessTokenAsync()
        {
            try
            {
                // 1️⃣ Access token still valid
                if (_token != null && DateTime.Now < _accessTokenExpiry)
                {
                    return _token.access_token;
                }

                // 2️⃣ Access token expired but refresh token valid
                if (_token != null && DateTime.Now < _refreshTokenExpiry)
                {
                    await RefreshTokenAsync();
                    return _token.access_token;
                }

                // 3️⃣ Both expired → request new token
                await RequestNewTokenAsync();

                return _token.access_token;
            }
            catch (Exception ex)
            {
                log.Error("Token error", ex);
                throw;
            }
        }


        private static async Task RequestNewTokenAsync()
        {
        
        
            var body = new Dictionary<string, string>
                                                     {
                                                         { "client_id", clientId },
                                                         { "client_secret", clientSecret },
                                                         { "grant_type", "password" },
                                                         { "username", username },
                                                         { "password", password },
                                                         { "scope", scope }
                                                     };

            var content = new FormUrlEncodedContent(body);

            var response = await client.PostAsync(tokenUrl, content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Token request failed: {response.StatusCode}");
            }

            var json = await response.Content.ReadAsStringAsync();

            _token = JsonConvert.DeserializeObject<APIToken>(json);

            SetExpiryTimes();
        }


        private static async Task RefreshTokenAsync()
        {
            var body = new Dictionary<string, string>
                                                     {
                                                         { "client_id", clientId },
                                                         { "client_secret", clientSecret },
                                                         { "grant_type", "refresh_token" },
                                                         { "refresh_token", _token.refresh_token }
                                                     };

            var content = new FormUrlEncodedContent(body);

            var response = await client.PostAsync(tokenUrl, content);

            if (!response.IsSuccessStatusCode)
            {
                log.Warn("Refresh token failed. Requesting new token...");
                await RequestNewTokenAsync();
                return;
            }

            var json = await response.Content.ReadAsStringAsync();

            _token = JsonConvert.DeserializeObject<APIToken>(json);

            SetExpiryTimes();
        }

        private static void SetExpiryTimes()
        {
            _accessTokenExpiry = DateTime.Now.AddSeconds(_token.expires_in - 60);
            _refreshTokenExpiry = DateTime.Now.AddSeconds(_token.refresh_expires_in - 60);
        }

    }
}
