using System.Text.Json.Serialization;

namespace UsersApp {
    public class User {
        private string firstName;
        private string lastName;

        public string FirstName { 
            get => firstName;
            set {
                if(string.IsNullOrWhiteSpace(value)) {
                    throw new ArgumentNullException(nameof(firstName));
                }

                firstName = value.Trim();
            }
        }
        public string LastName { 
            get => lastName;
            set {
                if (string.IsNullOrWhiteSpace(value)) {
                    throw new ArgumentNullException(nameof(lastName));
                }

                lastName = value.Trim();
            }
        }

        [JsonIgnore]
        public string FullName => $"{FirstName} {LastName}";

        public User(string firstName, string lastName) {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString() => this.FullName;
    }
}
