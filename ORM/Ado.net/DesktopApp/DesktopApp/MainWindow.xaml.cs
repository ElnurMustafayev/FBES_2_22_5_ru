using DesktopApp.Entities;
using DesktopApp.Repositories;
using System.Windows;

namespace DesktopApp
{
    public partial class MainWindow : Window
    {
        private const string connectionString = $"Server=localhost;Database=TestDb;User Id=admin;Password=admin;";
        private readonly UserRepository userRepository;

        public MainWindow()
        {
            InitializeComponent();

            this.userRepository = new UserRepository(connectionString);

            this.SetAllUsers();
        }

        private void SetAllUsers()
        {
            var allUsers = this.userRepository.GetAll();

            this.UsersListView.Items.Clear();

            foreach (var user in allUsers)
            {
                this.UsersListView.Items.Add(user);
            }
        }

        private void CreateUserButton_Click(object sender, RoutedEventArgs e)
        {
            var newUser = new User()
            {
                Name = this.NameTextBox.Text,
                Age = int.TryParse(this.AgeTextBox.Text, out int age) ? age : -1,
            };

            this.userRepository.Create(newUser);

            this.NameTextBox.Clear();
            this.AgeTextBox.Clear();

            this.SetAllUsers();
        }
    }
}
