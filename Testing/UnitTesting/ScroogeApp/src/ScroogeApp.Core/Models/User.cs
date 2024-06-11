namespace ScroogeApp.Core.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Money { get; set; }
    public bool IsInEmbargo { get; set; }
}