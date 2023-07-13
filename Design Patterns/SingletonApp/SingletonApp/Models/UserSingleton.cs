namespace SingletonApp.Models;

public class UserSingleton {
    public string? Login { get; set; }
    public string? Password { get; set; }
    public string? Nickname { get; set; }
    public bool IsLogined { get; set; } = false;

    private static UserSingleton user;

    public static UserSingleton Instance {
        get {
            if(user == null)
                user = new UserSingleton();

            return user;
        }
    }

    private UserSingleton() {

    }
}