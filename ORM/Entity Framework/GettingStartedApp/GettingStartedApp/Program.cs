// 1. dotnet add package Microsoft.EntityFrameworkCore
// 2. dotnet add package Microsoft.EntityFrameworkCore.SqlServer
// 3. dotnet add package Microsoft.EntityFrameworkCore.Design
// 4. dotnet tool install --global dotnet-ef
// 5. dotnet-ef migrations add "Init"
// 6. dotnet-ef database update

using GettingStartedApp;
using GettingStartedApp.Entities;
using GettingStartedApp.Repositories;
using GettingStartedApp.Repositories.Base;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Diagnostics;

var context = new MyDbContext();

//context.Database.EnsureCreated();


var entry = await context.Users.AddAsync(new User()
{
    Name = "Emil",
    Surname = "Babayev",
});

await context.SaveChangesAsync();

Console.WriteLine(entry.Entity.Id);




//var result = context.Users.Count(u => u.Surname.ToLower() == "marley");
//Console.WriteLine(result);



//var maxAge = context.Users.Max(u => u.Age);
//var minAge = context.Users.Min(u => u.Age);
//Console.WriteLine($"{minAge} {maxAge}");


// select
if (false)
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


    EntityEntry<User> result = context.Users.Add(newUser);

    context.SaveChanges();

    Console.WriteLine(newUser);
}

// update
if (false)
{
    var user = context.Users.First(u => u.Id == 5);

    user.Name = "Bob";
    user.Surname = "Marley";

    var result = context.Users.Update(user);
    context.SaveChanges();
    Console.WriteLine(result.Entity);
}

// delete
if(false)
{
    context.Users.Remove(new User
    {
        Id = 5
    });
    context.SaveChanges();
}

// repo
if(false)
{
    IUserRepository userRepository = new UserEfCoreRepository();

    userRepository = new UserDapperRepository();
    // delete
    if (true)
    {
        userRepository.Delete(4);
    }

    // update
    if(false)
    {
        var user = new User
        {
            Name = "Elnur",
            Surname = "Mustafayev",
        };
        userRepository.Update(5, user);
    }

    // create
    if(false)
    {
        var created = userRepository.Create(new User
        {
            Name = "Bob",
            Surname = "Marley",
            Age = 64,
            IsMarried = false,
        });

        Console.WriteLine(created);
    }


    // get
    if (false)
    {
        var users = userRepository.GetAll();

        foreach (var user in users)
        {
            Console.WriteLine(user);
        }
    }
}

