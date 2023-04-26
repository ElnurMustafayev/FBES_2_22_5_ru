namespace PropertiesApp {
    public class User<TId> {
        public TId id;

        public User() { }
        public User(TId id) => this.id = id;

        public static User<TId> Create(TId id) {
            return new User<TId>(id);
        }
    }

    public class Program {
        static void Main() {
            //var user = new User<double>();
            //var test = User<decimal>.Create(23.6M);
            //Console.WriteLine(test.id.GetType());

            //var num = 123;
            //num = "qwerty";


        }
    }
}