using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ViewModelApp.Models;

public class User
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("surname")]
    public string? Surname { get; set; }
}