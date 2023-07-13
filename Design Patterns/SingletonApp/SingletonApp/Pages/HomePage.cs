namespace SingletonApp.Pages;

using SingletonApp.Models;
using SingletonApp.Pages.Base;

public class HomePage : Page {
    //protected User? loginedUser;

    //public HomePage(User? user) {
    //    this.loginedUser = user;
    //}

    public override void Print() {
        base.Print();

        //if (this.loginedUser != null) {
        //    Console.WriteLine($"Hello, {this.loginedUser.Nickname}\n");
        //}
        //if (string.IsNullOrWhiteSpace(User.Login) == false) {
        //    Console.WriteLine($"Hello, {User.Nickname}\n");
        //}
        if(UserSingleton.Instance.IsLogined) {
            Console.WriteLine($"Hello, {UserSingleton.Instance.Nickname}\n");
        }

        Console.WriteLine("Product 1 - 50$");
        Console.WriteLine("Product 2 - 23$");
        Console.WriteLine("Product 3 - 1.5$");
        Console.WriteLine("Product 4 - 1$");
        Console.WriteLine("Product 5 - 1455$");
    }
}