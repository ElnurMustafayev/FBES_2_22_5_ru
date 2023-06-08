using System.Text.Json.Serialization;

namespace JsonApp {
    public class Teacher {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [JsonIgnore]
        public string FullName => $"{FirstName} {LastName}";
    }
}
