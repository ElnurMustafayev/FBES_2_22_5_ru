namespace ObservableApp;

using System;

public class User {
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? AvatarUrl { get; set; }
    public DateTime? BirthDate { get; set; }

    public User(string? name, string? surname, DateTime? birthDate) {
        this.Name = name;
        this.Surname = surname;
        this.BirthDate = birthDate;
        this.AvatarUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTd3XvjGg2xrNkgOW6qyLDtESTccZCxKqIZlQ&usqp=CAU";
    }

    public override string ToString() => $"{Name} {Surname} - {BirthDate?.ToShortDateString()}";
}
