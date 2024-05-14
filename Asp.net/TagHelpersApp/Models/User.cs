namespace TagHelpersApp.Models;

public class User
{
    public Guid? Uid { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public User(Guid uid, string name, string surname)
    {
        this.Uid = uid;
        this.Name = name;
        this.Surname = surname;
    }

    #pragma warning disable CS8618
    public User() { }
    #pragma warning restore CS8618
}