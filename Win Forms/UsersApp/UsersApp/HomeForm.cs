using System.Collections;
using System.Text.Json;

namespace UsersApp {
    public partial class HomeForm : Form {
        private Form addNewUserForm;
        private const string usersFilePath = "users.json";

        public HomeForm() {
            InitializeComponent();

            var users = Load<User>(usersFilePath);
            foreach (var user in users) {
                this.UsersListBox.Items.Add(user);
            }

            this.addNewUserForm = new AddNewUserForm(this.UsersListBox.Items);
        }

        protected override void OnFormClosed(FormClosedEventArgs e) {
            base.OnFormClosed(e);
            Save(this.UsersListBox.Items, usersFilePath);
        }

        private void Save(IEnumerable objects, string filepath) {
            var json = JsonSerializer.Serialize(objects);
            File.WriteAllText(filepath, json);
        }

        private IEnumerable<T> Load<T>(string filepath) {
            if (File.Exists(filepath) == false)
                File.Create(filepath);

            var json = File.ReadAllText(filepath);
            return JsonSerializer.Deserialize<IEnumerable<T>>(json);
        }

        private void AddNewUserButton_Click(object sender, EventArgs e) {
            //var form = new AddNewUserForm(this.UsersListBox.Items);
            this.addNewUserForm.ShowDialog();
        }
    }
}