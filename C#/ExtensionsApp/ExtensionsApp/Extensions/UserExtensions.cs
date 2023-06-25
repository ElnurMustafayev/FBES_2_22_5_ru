namespace ExtensionsApp.Extensions;

using ExtensionsApp.Models;

public static class UserExtensions {
    public static void Show(this User user) {
        Console.WriteLine($@"User info:

Name: {user.Name}
Surname: {user.Surname}
Birthdate: {user.BirthDate?.ToShortDateString()}");
    }

    public static bool Check(this User user) {
        if (user == null)
            return false;

        else if (string.IsNullOrEmpty(user.Name)
            || string.IsNullOrEmpty(user.Surname))
            return false;

        else if (user.BirthDate.HasValue == false || user.BirthDate > DateTime.Now)
            return false;

        return true;
    }
}