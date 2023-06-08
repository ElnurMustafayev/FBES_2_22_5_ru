using System.Text.Json;

namespace JsonApp {
    public class User {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime CreationDateUtc { get; set; } = DateTime.UtcNow;
        public bool IsMarried { get; set; }


        // JSON
        public void SaveJson(string filePath) {
            string json = JsonSerializer.Serialize(this);

            File.WriteAllText(filePath, json);
        }

        public static User LoadJson(string filePath) {
            string json = File.ReadAllText(filePath);

            return JsonSerializer.Deserialize<User>(json);
        }



        // TEXT
        public void LoadText(string filePath) {
            string dataTxt = File.ReadAllText(filePath);

            var data = dataTxt.Split(',', StringSplitOptions.None);

            this.FirstName = data[0];
            this.LastName = data[1];
            this.Age = int.Parse(data[2]);
        }

        public void SaveText(string filePath) {
            string dataTxt = $"{FirstName},{LastName},{Age}";

            File.WriteAllText(filePath, contents: dataTxt);
        }
    }
}
