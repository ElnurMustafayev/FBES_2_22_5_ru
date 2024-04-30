using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationApp.Extensions
{
    public static class ConfigurationExtensions
    {
        public static string GetConnectionStringOrThrowArgumentException(this IConfiguration configuration, string name) {
            var connectionString = configuration.GetConnectionString(name);

            if(string.IsNullOrWhiteSpace(connectionString)) {
                throw new ArgumentException($"Connection string not found in settings file by name: '{name}'", connectionString);
            }

            return connectionString;
        }
    }
}