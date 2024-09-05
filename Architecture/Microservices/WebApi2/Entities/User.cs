#pragma warning disable CS8618

namespace WebApi2.Entities;

public class User
{
    public long Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }
}