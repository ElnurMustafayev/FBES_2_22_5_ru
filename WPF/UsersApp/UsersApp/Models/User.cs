using System.Text.Json.Serialization;

namespace UsersApp.Models;

public class User {
    public string? Name { get; set; }
    public string? Surname { get; set; }

    [JsonIgnore]
    public string? Fullname => $"{Name ?? "Unknown"} {Surname ?? "Unknown"}";
}