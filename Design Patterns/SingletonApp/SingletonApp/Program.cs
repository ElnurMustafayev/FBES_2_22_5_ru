using SingletonApp.Models;
using SingletonApp.Pages;
using SingletonApp.Pages.Base;

namespace SingletonApp {
    class Program {
        static void Main() {

            if(false) {
                UserSingleton.Instance.Login = "Test";
                Console.WriteLine(UserSingleton.Instance.Login);
                Console.WriteLine(UserSingleton.Instance.Login);
                Console.WriteLine(UserSingleton.Instance.Login);

                UserSingleton.Instance.Login = "Qwerty";
                Console.WriteLine(UserSingleton.Instance.Login);
                Console.WriteLine(UserSingleton.Instance.Login);
            }


            if(false) {
                UserSingleton obj1 = UserSingleton.Instance;
                UserSingleton obj2 = UserSingleton.Instance;
                UserSingleton obj3 = UserSingleton.Instance;

                Console.WriteLine(obj1.GetHashCode());
                Console.WriteLine(obj2.GetHashCode());
                Console.WriteLine(obj3.GetHashCode());
            }




            Page? currentPage = null;
            User? loginedUser = null;

            while(true) {
                Console.Clear();
                currentPage?.Print();

                switch (Console.ReadKey().Key) {
                    case ConsoleKey.D1:
                        //currentPage = new BucketPage(loginedUser);
                        currentPage = new BucketPage();
                        break;

                    case ConsoleKey.D2:
                        //currentPage = new HomePage(loginedUser);
                        currentPage = new HomePage();
                        break;

                    case ConsoleKey.D3:
                        //loginedUser = new User() {
                        //    Login = "admin",
                        //    Password = "admin",
                        //    Nickname = "ElnurMustafayev",
                        //};

                        //User.Login = "admin";
                        //User.Password = "admin";
                        //User.Nickname = "ElnurMustafayev";

                        UserSingleton user = UserSingleton.Instance;

                        user.IsLogined = true;
                        user.Login = "admin";
                        user.Password = "admin";
                        user.Nickname = "ElnurMustafayev";

                        break;
                }
            }
        }
    }
}