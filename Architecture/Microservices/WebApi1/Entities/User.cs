#pragma warning disable CS8618

namespace WebApi1.Entities;

public class User
{
    public string Email { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Password { get; set; }
    public DateTime BirthDate { get; set; }
}