using System;

namespace DependencyInjectionApp.Models
{
    public class Product
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public int? Status { get; set; }

        public override string ToString() => Name ?? "Unknown";
    }
}
