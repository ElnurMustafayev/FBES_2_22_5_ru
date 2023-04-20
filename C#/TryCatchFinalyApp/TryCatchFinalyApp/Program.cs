namespace TryCatchFinalyApp {
    public class Program {
        static void Main() {
            try {
                Person person = new Person("Test", "asd", -12);
            }
            catch(ArgumentException ex) {
                Console.WriteLine($"ArgumentException: '{ex.Message}'");
            }
            catch(Exception ex) {
                Console.WriteLine($"Error: '{ex.Message}'");
            }
        }
    }
}