using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.IO;
using System;
using System.Configuration;

namespace DesafioAutomacaoMantis.Helpers
{
    public class JsonBuilder
    {
        public static IConfigurationRoot configuration { get; set; } = null;

        //private static string appSettingsPath { get { return AppContext.BaseDirectory + "/appsettings.json"; } }

        //private static string ReadAppSettingsContent()
        //{
        //    return File.ReadAllText(appSettingsPath);
        //}

        public static string GetAppSettings(string param)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            configuration = builder.Build();

            return configuration[param];

            // return JObject.Parse(ReadAppSettingsContent());

        }
    }
}
