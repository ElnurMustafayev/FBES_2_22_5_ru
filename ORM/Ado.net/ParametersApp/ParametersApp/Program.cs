using ParametersApp.Entities;
using ParametersApp.Repositories;
using System.Data.SqlClient;




const string connectionString = $"Server=localhost;Database=TestDb;User Id=admin;Password=admin;";

using var sqlConnection = new SqlConnection(connectionString);
sqlConnection.Open();

Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("Age: ");
int age = int.TryParse(Console.ReadLine(), out int ageInput) ? ageInput : -1;

// SOLUTION
if(true)
{
    var command = new SqlCommand(
        cmdText: @$"insert into Users(Name, Age) 
                    values(@name, @age)",
        sqlConnection);

    command.Parameters.Add(new SqlParameter("name", name));
    command.Parameters.Add(new SqlParameter("age", age));

    command.ExecuteNonQuery();
}

// SQL INJECTION
if(false)
{
    var command = new SqlCommand(
        cmdText: @$"insert into Users(Name, Age) 
                    values('{name}', {age})",
        sqlConnection);

    command.ExecuteNonQuery();
}

/*
const string connectionString = $"Server=localhost;Database=TestDb;User Id=admin;Password=admin;";
var userRepository = new UserRepository(connectionString);

User newUser = new User()
{
    Name = "Emil",
    Age = 21
};

userRepository.Create(newUser);


var users = userRepository.GetAll();

foreach (var user in users)
{
    System.Console.WriteLine(user);
}

*/


// 1. create entity
// 2. create repository class for entity
// 3. create method in repository: GetById(int id) 


// command.Parameters.Add(new SqlParameter("name", name));