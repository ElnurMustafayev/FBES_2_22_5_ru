using System.Text.Json.Serialization;

namespace DependencyInjectionApp.Models;

public class Product
{
    public string? Name { get; set; }
    public double? Price { get; set; }
    public bool? InStock { get; set; }
    public double? Discount { get; set; }

    [JsonIgnore]
    public double? PriceWithDiscount {
        get {
            if(Price != null && Discount != null) {
                return Price - (Price * Discount / 100);
            }

            return null;
        }
    }
}