using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Windows;
using UsersApp.Models;

namespace UsersApp.Windows;

public partial class MainWindow : Window, INotifyPropertyChanged {

    public event PropertyChangedEventHandler? PropertyChanged;
    public ObservableCollection<User> Users { get; set; }

    private User selectedUser;
    public User SelectedUser { 
        get => selectedUser;
        set => this.PropertyChangeMethod(out this.selectedUser, value);
    }

    public MainWindow() {
        InitializeComponent();

        this.DataContext = this;

        var loadedUsers = this.LoadUsers();
        this.Users = new ObservableCollection<User>(loadedUsers);
    }

    protected void PropertyChangeMethod<T>(out T field, T value, [CallerMemberName] string propName = "") {
        field = value;

        if (this.PropertyChanged != null) {
            this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }

    private void OpenAddWindow(object sender, RoutedEventArgs e) {
        new AddWindow(this.Users).ShowDialog();
    }

    protected override void OnClosing(CancelEventArgs e) {
        base.OnClosing(e);

        this.SaveUsers();
    }

    private IEnumerable<User> LoadUsers() {
        string filePath = "Data/Users.json";

        string usersJson = File.ReadAllText(filePath);
        var users = JsonSerializer.Deserialize<IEnumerable<User>>(usersJson);
        return users;
    }

    private void SaveUsers() {
        string filePath = "Data/Users.json";

        string usersJson = JsonSerializer.Serialize(this.Users);
        File.WriteAllText(filePath, usersJson);
    }

    private void DeleteSelectedUser(object sender, System.Windows.Input.MouseButtonEventArgs e) {
        this.Users.Remove(this.SelectedUser);
    }
}