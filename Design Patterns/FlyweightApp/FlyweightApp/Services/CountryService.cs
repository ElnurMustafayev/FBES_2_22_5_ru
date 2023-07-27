namespace FlyweightApp.Services;

using FlyweightApp.Models;
using System.Runtime.Caching;
using System.Text.Json;

public class CountryService {
    private readonly MemoryCache cache;

    public CountryService(MemoryCache cache) {
        this.cache = cache;
    }

    public Country GetCountry(string code) {
        code = code.ToUpper();
        var resultFromCache = cache.Get(code);

        if (resultFromCache != null && resultFromCache is Country) {
            Console.WriteLine("Got from cache!");
            return (resultFromCache as Country)!;
        }

        var json = File.ReadAllText("countries.json");
        var countries = JsonSerializer.Deserialize<IEnumerable<Country>>(json);
        var resultFromFile = countries?.FirstOrDefault(c => c.Code?.ToUpper() == code);
        
        Thread.Sleep(1000);
        Console.WriteLine("Got from Json file!");

        if(resultFromFile == null) {
            throw new Exception($"Country with code '{code}' not found!");
        }

        if(!string.IsNullOrEmpty(resultFromFile.Code)) {
            cache.Add(
                item: new CacheItem(key: resultFromFile.Code, value: resultFromFile),
                policy: new CacheItemPolicy() {
                    AbsoluteExpiration = DateTime.Now.AddSeconds(10),
                    RemovedCallback = (args) => {
                        if (args.CacheItem.Value is Country country) {
                            Console.WriteLine($"Country '{country.Name}' Removed!");
                        }
                    },
                });
        }

        return resultFromFile;
    }
}