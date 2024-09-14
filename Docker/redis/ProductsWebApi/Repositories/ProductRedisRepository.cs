namespace ProductsWebApi.Repositories;

using System.Text.Json;
using System.Threading.Tasks;
using ProductsWebApi.Entities;
using ProductsWebApi.Repositories.Base;
using StackExchange.Redis;

public class ProductRedisRepository : IProductRepository
{
    private readonly string connectionString;
    private readonly IProductRepository productRepository;

    public ProductRedisRepository(IProductRepository productRepository, IConfiguration configuration)
    {
        this.productRepository = productRepository;
        this.connectionString = configuration.GetConnectionString("Redis") ?? throw new ArgumentException();
    }
    
    public async Task<Product?> GetAsync(int id)
    {
        var redisKey = $"product_{id}";
        var connection = ConnectionMultiplexer.Connect(this.connectionString);
        var database = connection.GetDatabase();

        var redisValue = await database.StringGetAsync(redisKey);

        if(redisValue.HasValue) {
            var productFromCache = JsonSerializer.Deserialize<Product>(redisValue.ToString());
            System.Console.WriteLine("GOT FROM REDIS!");
            return productFromCache;
        }

        var productFromStorage = await productRepository.GetAsync(id);

        if(productFromStorage != null) {
            await database.StringSetAsync(redisKey, JsonSerializer.Serialize(productFromStorage));
        }

        System.Console.WriteLine("GOT FROM STORAGE!");
        return productFromStorage;
    }
}