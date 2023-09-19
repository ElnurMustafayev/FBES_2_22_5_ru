using System.Data.SqlClient;
using GettingStartedApp.Entities;
using Dapper;
using GettingStartedApp.Repositories;

const string connectionString = $"Server=localhost;Database=TestDb;User Id=admin;Password=admin;";

using SqlConnection sqlConnection = new SqlConnection(connectionString);
sqlConnection.Open();

//if(true)
//{
//    dynamic num = new User() { Name = "Bob" };

//    Console.WriteLine(num.Name);
//}

if(true)
{
    ProductRepository productRepository = new ProductRepository(connectionString);

    var product = productRepository.GetById(1);

    Console.WriteLine(product);
}



if(false) {
    //int result = sqlConnection.ExecuteScalar<int>(sql: "select max(Age) from Users");
    //Console.WriteLine(result);




    //var users = sqlConnection.Query<User>(sql: "select * from Users");

    //foreach (var user in users)
    //{
    //    Console.WriteLine(user);
    //}



    string query = $@"select top 1 *
                    from Users u
                    where u.Name = @Name or u.Age = @Age";

    UserParameters userParameters = new UserParameters(name: "Elnur", age: 77);
    var result = sqlConnection.QueryFirstOrDefault<User>(
        sql: query,
        param: userParameters);

    Console.WriteLine(result);
}


if(false) {
    using SqlCommand sqlCommand= sqlConnection.CreateCommand();
    sqlCommand.CommandText = $"select * from Users";
    var reader = sqlCommand.ExecuteReader();

    while (reader.Read()) {
        User user = new User() {
            Id = reader.GetInt32(0),
            //Name = reader.GetString(1),
            Age = reader.GetInt32(2),
        };

        System.Console.WriteLine(user);
    }
}
