namespace StaticApp {
    public class MyInt {
        public static bool TryParse(string numStr, out int result) {
            try {
                result = Convert.ToInt32(numStr);
                return true;
            }
            catch {
                result = default;
                return false;
            }
        }

        public bool Test() {
            try {
                int result = Convert.ToInt32(Console.ReadLine());
                return true;
            }
            catch {
                Console.WriteLine("Error!!!");
                throw;
            }
        }
    }
}
