using RelationsApp.Data;
using RelationsApp.Entities;
using RelationsApp.Entities.OneToMany;

MyDbContext dbContext = new MyDbContext();

dbContext.Database.EnsureCreated();


// one-to-one
//var result = dbContext.Users
//    .Select(u => u)
//    .Join(
//        inner: dbContext.Countries, 
//        outerKeySelector: u => u.CountryId, 
//        innerKeySelector: c => c.Id,
//        resultSelector: (u, c) => new { u.Mail, c.Name })
//    .ToList();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//var country = dbContext.Countries.First(c => c.Name.Contains("Az"));

//dbContext.Users.Add(new User()
//{
//    Mail = "Sadiq",
//    Password = "hackerman",
//    CountryId = country.Id,
//    //Country = country,
//});

//dbContext.Users.Add(new User()
//{
//    Mail = "Emil",
//    Password = "test",
//    Country = new Country()
//    {
//        Name = "Austriya"
//    },
//});



// many-to-many

//dbContext.Posts.Add(new Post
//{
//    Title = "Test Title",
//    Text = "Test Text",
//    Comments = new List<Comment>
//    {
//        new Comment() {Text = "looooool"},
//        new Comment() {Text = "hahahahhaha"},
//        new Comment() {Text = "..."},
//    }
//});

var result = dbContext.Posts.Select(p => p)
    .ToList();


dbContext.SaveChanges();