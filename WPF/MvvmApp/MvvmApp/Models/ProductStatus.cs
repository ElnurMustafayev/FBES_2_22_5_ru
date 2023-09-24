namespace MvvmApp.Models
{
    public class ProductStatus
    {
        public int Id{ get; set; }
        public string? Name{ get; set; }

        public override string ToString() => Name ?? "Unknown";
    }
}
