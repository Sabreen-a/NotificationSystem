using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    static class ConfigLoader
    {
        public static EmailSettings LoadSettings()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Appsetting.json");

            if (!File.Exists(filePath))
                throw new FileNotFoundException($" ملف الإعدادات غير موجود: {filePath}");

            string settingString = File.ReadAllText(filePath);
            JObject json = JObject.Parse(settingString);
            return json["EmailSettings"]?.ToObject<EmailSettings>()
                   ?? throw new Exception(" إعدادات البريد الإلكتروني غير موجودة في ملف Appsetting.json");
        }
    }
 
   
}
