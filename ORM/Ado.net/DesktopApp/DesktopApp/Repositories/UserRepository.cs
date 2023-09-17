namespace DesktopApp.Repositories;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DesktopApp.Entities;

public class UserRepository {
    private SqlConnection sqlConnection;

    public UserRepository(string connectionString)
    {
        this.sqlConnection = new SqlConnection(connectionString);

        this.sqlConnection.Open();
    }

    public IEnumerable<User> GetAll() {
        List<User> users = new List<User>();

        var command = new SqlCommand(
            cmdText: @$"select * from Users", 
            this.sqlConnection);

        var reader = command.ExecuteReader();

        while(reader.Read()) {
            var user = new User() {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Age = reader["Age"] is DBNull ? null : (int)reader["Age"]
            };

            users.Add(user);
            // reader.GetInt32(0);
            // reader.GetString(1);
            // reader.GetInt32(2);
        }

        return users;
    }

    public bool Create(User newUser) {
        // string query = newUser.Age is null
        //     ? $"insert into Users(Name) values('{newUser.Name}')"
        //     :$"insert into Users(Name, Age) values('{newUser.Name}', {newUser.Age})";

        var command = new SqlCommand(
            cmdText:    @$"insert into Users(Name, Age) 
                        values(@Name, @Age)", 
            this.sqlConnection);

        command.Parameters.Add(new SqlParameter(nameof(newUser.Name), newUser.Name));
        command.Parameters.Add(new SqlParameter(nameof(newUser.Age), newUser.Age));

        return command.ExecuteNonQuery() > 0;
    }
}