using FlyweightApp.Services;
using System.Linq.Expressions;
using System.Runtime.Caching;

namespace FlyweightApp {
    class Program {
        static void Main() {
            var memoryCache = new MemoryCache("countries");
            var countryService = new CountryService(memoryCache);

            while(true) {
                try {
                    var code = Console.ReadLine();
                    if (code == null)
                        continue;

                    var country = countryService.GetCountry(code);
                    Console.WriteLine(country);
                }
                catch(Exception ex) {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}