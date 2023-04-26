namespace PropertiesApp {
    public class Person {
        private string name;
        private int age;


        public string GetName() => this.name;
        public void SetName(string name) {
            this.name = name;
        }

        public int GetAge() {
            return this.age;
        }
        public void SetAge(int age) => this.age = age;
    }
}