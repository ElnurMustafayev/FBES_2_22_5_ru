namespace DateTimeApp {
    public class User {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }

        public User(string name, string surname, DateTime birthdate) {
            this.Name = name;
            this.Surname = surname;
            this.Birthdate = birthdate;
        }

        public override string ToString() {
            return @$"Name: {this.Name}
Surname: {this.Surname}
Birthdate: {this.Birthdate}";
        }
    }
}
