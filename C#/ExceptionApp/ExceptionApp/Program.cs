namespace ExceptionApp {
    public class MyCustomException : ArgumentException {
        public override string Message => $"Error: '{base.Message}'";
        public override string? ParamName => "test";

        public MyCustomException(string message) : base(message) {
        }
    }

    public class Program {
        static void Main() {
            try {
                var ex = new MyCustomException("There is my error message!");
                throw ex;
            }
            catch(ArgumentException ex) {
                Console.WriteLine(ex.ParamName);
            }
        }
    }
}