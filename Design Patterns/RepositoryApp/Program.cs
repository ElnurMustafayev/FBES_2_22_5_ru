using System.Data.SqlClient;
using RepositoryApp.Entities;
using RepositoryApp.Repositories;

const string connectionString = $"Server=localhost;Database=TestDb;User Id=admin;Password=admin;";

UserRepository userRepository = new UserRepository(connectionString);

if(true) {
    User newUser = new User() {
        Name = "Emil",
        Age = 21
    };

    userRepository.Create(newUser);
}

if(true) {
    var users = userRepository.GetAll();

    foreach (var user in users)
    {
        System.Console.WriteLine(user);
    }
}
