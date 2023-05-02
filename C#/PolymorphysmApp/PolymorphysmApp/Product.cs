namespace PolymorphysmApp {
    public class Product {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual void ShowInfo() {
            Console.WriteLine($"Name: '{Name}'");
            Console.WriteLine($"Price: {Price}$");
        }

        public static void ShowProductInfo(Product product) {
            product.ShowInfo();
        }
    }

    public class FreshProduct : Product {
        public string ExpirationDateStr { get; set; }

        public override void ShowInfo() {
            base.ShowInfo();
            Console.WriteLine($"Expiration: {ExpirationDateStr}");
        }
    }
}
