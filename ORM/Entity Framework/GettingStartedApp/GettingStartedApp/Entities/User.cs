namespace GettingStartedApp.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public bool? IsMarried { get; set; }

    public override string ToString() => $"#{Id}. {Name} {Surname}, {Age} - {IsMarried}";
}