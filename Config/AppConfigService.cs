using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LANMIC_ComBank_Interface.Config
{
    public class AppConfigService
    {
        private static string _configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");

        public static bool ConfigExists() => File.Exists(_configPath);

        public static AppConfigService Load()
        {
            var json = File.ReadAllText(_configPath);
            return JsonSerializer.Deserialize<AppConfigService>(json);
        }

        public static void Save(AppConfigService config)
        {
            var json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_configPath, json);
        }
    }
}
