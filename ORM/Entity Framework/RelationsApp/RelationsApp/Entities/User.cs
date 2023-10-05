using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RelationsApp.Entities;

public class User
{
    //[Key]
    //[Column(Order = 0)]
    public Guid MyPrimaryKey { get; set; }

    //[Required]
    public string Mail { get; set; }
    //[Required]
    public string Password { get; set; }

    // one-to-one
    public Country? Country { get; set; }
    public int? CountryId { get; set; }
}