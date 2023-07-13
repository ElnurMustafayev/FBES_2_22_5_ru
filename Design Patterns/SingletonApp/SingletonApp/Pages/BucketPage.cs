namespace SingletonApp.Pages;

using SingletonApp.Models;
using SingletonApp.Pages.Base;

public class BucketPage : Page {
    //protected User? loginedUser;

    //public BucketPage(User? user) {
    //    this.loginedUser = user;
    //}

    public override void Print() {
        base.Print();

        //if(this.loginedUser == null) {
        //if(string.IsNullOrWhiteSpace(User.Login)) {
        if(UserSingleton.Instance.IsLogined == false) {
            Console.WriteLine("Please login");
            return;
        }

        Console.WriteLine("Apples - 10$");
        Console.WriteLine("Phone - 1200$");
        Console.WriteLine("Tv - 700$");

        Console.WriteLine($"1910$");
    }
}