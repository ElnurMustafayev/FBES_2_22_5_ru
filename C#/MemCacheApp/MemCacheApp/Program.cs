namespace MemCacheApp;

using System.Runtime.Caching;

public class Country {
    public Country(string name, string code) {
        Name = name;
        Code = code;
    }

    public string Name { get; set; }
    public string Code { get; set; }

    public override string ToString() => $"{Name}({Code})";
}

class Program {
    static void Main() {
        MemoryCache memoryCache = new MemoryCache(name: "TestCache");

        var cacheCountry = new Country("Azerbaijan", code: "AZ");
        CacheItem cacheItem = new CacheItem(key: cacheCountry.Code, value: cacheCountry);

        var cacheItemPolicy = new CacheItemPolicy() {
            AbsoluteExpiration = DateTime.Now.AddSeconds(2),
            RemovedCallback = (args) => {
                if (args.CacheItem.Value is Country country) {
                    Console.WriteLine($"Country '{country.Name}' Removed!");
                }
            },
        };
        memoryCache.Add(cacheItem, cacheItemPolicy);
        memoryCache.Add("RU", "Russia", null);

        Console.ReadKey();

        object result = memoryCache.Get("AZ");
        Console.WriteLine(result ?? "Not found!");








        //Dictionary<string, object> cache = new Dictionary<string, object>();

        //cache["AZ"] = new Country();
        //cache["RU"] = new Country();
    }
}