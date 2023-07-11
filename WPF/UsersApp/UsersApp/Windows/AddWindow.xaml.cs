using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using UsersApp.Models;

namespace UsersApp.Windows {
    public partial class AddWindow : Window, INotifyPropertyChanged {
        public event PropertyChangedEventHandler? PropertyChanged;
        private readonly ObservableCollection<User>? users;

        private string? newUserName;
        public string? NewUserName {
            get => newUserName;
            set => this.PropertyChangeMethod(out newUserName, value);
        }

        private string? newUserSurname;

        public string? NewUserSurname {
            get => newUserSurname;
            set => this.PropertyChangeMethod(out newUserSurname, value);
        }

        public AddWindow() {
            InitializeComponent();

            this.DataContext = this;
        }

        public AddWindow(ObservableCollection<User>? users) : this() {
            this.users = users;
        }

        protected void PropertyChangeMethod<T>(out T field, T value, [CallerMemberName] string propName = "") {
            field = value;

            if (this.PropertyChanged != null) {
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propName));
            }
        }

        private void AddUserClick(object sender, RoutedEventArgs e) {
            this.users?.Add(new User() {
                Name = this.NewUserName,
                Surname = this.NewUserSurname,
            });

            this.Close();
        }

        private void CancelClick(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}
