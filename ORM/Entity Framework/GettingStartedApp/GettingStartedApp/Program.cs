// 1. dotnet add package Microsoft.EntityFrameworkCore
// 2. dotnet add package Microsoft.EntityFrameworkCore.SqlServer
// 3. dotnet add package Microsoft.EntityFrameworkCore.Design
// 4. dotnet tool install --global dotnet-ef
// 5. dotnet-ef migrations add "Init"
// 6. dotnet-ef database update

using GettingStartedApp;
using GettingStartedApp.Entities;
using System.Diagnostics;

var context = new MyDbContext();

//context.Database.EnsureCreated();



//var result = context.Users.Count(u => u.Surname.ToLower() == "marley");
//Console.WriteLine(result);



//var maxAge = context.Users.Max(u => u.Age);
//var minAge = context.Users.Min(u => u.Age);
//Console.WriteLine($"{minAge} {maxAge}");


// select
if (true)
{
    //foreach (var user in context.Users)
    //{
    //    Console.WriteLine(user);
    //}


    Stopwatch stopWatch = new Stopwatch();
    stopWatch.Start();

    Console.WriteLine($"before select {stopWatch.ElapsedMilliseconds}");

    var result = context.Users.Where(u => u.Name.Contains("g") && u.IsMarried == null);

    //var result = context.Users.Select(u => new {u.Id, u.Name});


    Console.WriteLine($"before select {stopWatch.ElapsedMilliseconds}");
    var users = result.ToList();
    Console.WriteLine($"after ToList {stopWatch.ElapsedMilliseconds}");
    stopWatch.Stop();
}




// insert 
if (false)
{
    var newUser = new User();

    Console.Write("Name: ");
    newUser.Name = Console.ReadLine();
    Console.Write("Surname: ");
    newUser.Surname = Console.ReadLine();
    Console.Write("Age: ");
    newUser.Age = int.TryParse(Console.ReadLine(), out int ageInput) ? ageInput : 0;
    Console.Write("Is Married ('y' - yes): ");
    newUser.IsMarried = Console.ReadLine() == "y";


    context.Users.Add(newUser);

    context.SaveChanges();
}