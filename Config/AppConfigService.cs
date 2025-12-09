using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LANMIC_ComBank_Interface.Models.SystemModels;

namespace LANMIC_ComBank_Interface.Config
{
    public class AppConfigService
    {
        private static string _configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");

        public static bool ConfigExists() => File.Exists(_configPath);

        public static DatabaseConfigModel Load()
        {
            var json = File.ReadAllText(_configPath);
            return JsonSerializer.Deserialize<DatabaseConfigModel>(json);
        }

        public static void Save(DatabaseConfigModel config)
        {
            var json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_configPath, json);
        }

        public static void Delete()
        {
            if (ConfigExists())
            {
                File.Delete(_configPath);
            }
        }

        public static string ConnectionString()
        {
            string connString = string.Empty;
            if(ConfigExists())
            {
                DatabaseConfigModel config = Load();
                connString = $"Server={config.Server};Database={config.DatabaseName};User Id={config.User};Password={config.Password};TrustServerCertificate=true;";
            }
            return connString;
        }
    }
}
