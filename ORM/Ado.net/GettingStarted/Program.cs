// 1. create project (console)
// 2. add nuget packages (System.Data.SqlClient)
// 3. init connection string (https://www.connectionstrings.com/sql-server/)
// 4. create and open connection (SqlConnection)

using GettingStarted.Entities;
using System.Data.SqlClient;



bool DeleteUser(SqlConnection connection, int id)
{
    string deleteQuery = $@"delete from Users where Id = {id}";
    SqlCommand cmd = new SqlCommand(deleteQuery, connection);

    return cmd.ExecuteNonQuery() > 0;
}

bool InsertUser(SqlConnection connection, User newUser)
{
    string deleteQuery =    $@"insert into Users(Name)
                            values('{newUser.Name}')";

    SqlCommand cmd = new SqlCommand(deleteQuery, connection);

    return cmd.ExecuteNonQuery() > 0;
}

const string serverAddress = "localhost";
const string databaseName = "TestDb";
const string login = "admin";
const string password = "admin";

const string connectionString = $"Server={serverAddress};Database={databaseName};User Id={login};Password={password};";

SqlConnection connection = new SqlConnection(connectionString);

try
{
    connection.Open();

    // scalar - value
    if(false)
    {
        SqlCommand command = new SqlCommand();

        command.Connection = connection;
        //command.CommandText = "select 100";
        //command.CommandText = "select u.Name from Users u";
        command.CommandText = "select max(u.Name) from Users u";

        object result = command.ExecuteScalar();
        Console.WriteLine(result);
    }

    // table - value
    if(false)
    {
        SqlCommand command = new SqlCommand()
        {
            Connection = connection,
            CommandText =   @"select Id, Name
                            from Users",
        };

        SqlDataReader reader = command.ExecuteReader();

        List<User> users = new List<User>();

        while(reader.Read())
        {
            //Console.WriteLine($"Id = {reader.GetInt32(0)}");
            //Console.WriteLine($"Name = {reader.GetString(1)}");

            users.Add(new User()
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
            });
        }

        //users[0].Name = "Test";
    }

    // non-query
    if (false)
    {
        SqlCommand command = new SqlCommand("delete from Users where Id = 3", connection);

        int affectedRowsCount = command.ExecuteNonQuery();

        Console.WriteLine($"Affected rows count: {affectedRowsCount}");
    }
    if(true)
    {
        //bool success = DeleteUser(connection, 13);
        bool success = InsertUser(connection, new User() { Name = "Emil" });
        Console.WriteLine(success);
    }
}
catch(SqlException ex)
{
    Console.WriteLine($"Sql exception: '{ex.Message}'");
}
catch(Exception ex)
{
    Console.WriteLine($"System exception: '{ex.Message}'");
}