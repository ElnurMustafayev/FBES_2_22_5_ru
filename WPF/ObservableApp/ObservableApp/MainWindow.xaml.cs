using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ObservableApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public ObservableCollection<User> Users { get; set; } 

        //public List<User> Users { get; set; } = new List<User>() {
        //    new User("Bob", "Marley", new DateTime(1968, 7, 9)),
        //};

        public MainWindow() {
            InitializeComponent();

            this.DataContext = this;


            var json = File.ReadAllText("./Assets/Users.json");
            var users = JsonSerializer.Deserialize<IEnumerable<User>>(json);

            this.Users = new ObservableCollection<User>(users);



            //this.MyListView.Items.Add(123);
            //this.MyListView.Items.Add("test");
            //this.MyListView.Items.Add(true);
            //this.MyListView.Items.Add(new User("Bob", "Marley", new DateTime(1968, 7, 9)));
            //this.MyListView.Items.Add(new User("Bob", "Marley", new DateTime(1968, 7, 9)));
            //this.MyListView.Items.Add(new User("Bob", "Marley", new DateTime(1968, 7, 9)));
            //this.MyListView.Items.Add(new User("Bob", "Marley", new DateTime(1968, 7, 9)));
            //this.MyListView.Items.Add(new User("Bob", "Marley", new DateTime(1968, 7, 9)));
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            this.Users.Add(new User(Guid.NewGuid().ToString()[1..5], Guid.NewGuid().ToString()[1..5], DateTime.Now));
        }
    }
}
