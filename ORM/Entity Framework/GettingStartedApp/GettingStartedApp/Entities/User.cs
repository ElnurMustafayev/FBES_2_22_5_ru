namespace GettingStartedApp.Entities;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("People")]
public class User
{
    public int Id { get; set; }

    [MaxLength(50)]
    public string Name { get; set; }
    [MaxLength(50)]
    public string Surname { get; set; }

    public int Age { get; set; }
    public bool? IsMarried { get; set; }

    [Column(name: "MyColumn")]
    public int? Property { get; set; }

    public override string ToString() => $"#{Id}. {Name} {Surname}, {Age} - {IsMarried}";
}