namespace PropertiesApp;


//class Car {
//    public int count;

//    protected string model;

//    public int WeelsCount { get; set; } = 4;

//    public string Model {
//        get => string.IsNullOrWhiteSpace(model) ? "Unknown" : this.model;
//        set {
//            const int maxLength = 50;

//            // validation
//            if (string.IsNullOrWhiteSpace(value))
//                throw new ArgumentNullException(paramName: nameof(value), message: "Model name can not be empty!");

//            if (value.Length > maxLength)
//                throw new ArgumentException(paramName: nameof(value), message: "Model name can not be more than 50 symbols!");

//            if (value.ToLower() == this.Model.ToLower())
//                throw new ArgumentException(paramName: nameof(value), message: "Write another Model name!");

//            this.model = value;
//        }
//    }
//}

public enum ProductStatus : int {
    soldout = 0,
    bestseller,
    unknown,
};

public class Product {
    //public ProductStatus Status { get; set; }
    //public ProductStatus Status { get; set; }


    //private ProductStatus status;

    //public ProductStatus Status {
    //    get => status;
    //    set => status = value;
    //}
}


public class User {
    private string nickname;
    private string login = "default";

    //public string Login => this.login;
    //public string NormalizedLogin => this.login.ToUpper();
    //public bool HasLogin => string.IsNullOrWhiteSpace(this.login);

    public string Login {
        get => this.login;
        protected set => this.login = value;
    }

    public string Nickname {
        get => this.nickname;
        set {
            if (this.Nickname == value) {
                throw new Exception();
            }
            this.nickname = value;
        }
    }


    public User(string nickname, string login) {
        this.Nickname = nickname;
        this.Login = login;
    }
}


//public class Person {
//    private int age;

//    public int Age {
//        // int GetAge()
//        get {
//            return this.age;
//        }

//        // void SetAge(int value)
//        set {
//            //Console.WriteLine($"SETTER with value: {value}");
//            this.age = value;
//        }
//    }
//}