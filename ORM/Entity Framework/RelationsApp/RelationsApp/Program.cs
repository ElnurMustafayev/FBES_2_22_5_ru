using RelationsApp.Data;
using RelationsApp.Entities;
using RelationsApp.Entities.ManyToMany;
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



// one-to-many

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

//var result = dbContext.Posts.Select(p => p)
//    .ToList();



// many-to-many
//dbContext.Groups.AddRange(
//    new Group("FBES_2_22_5_ru"),
//    new Group("Bob's groups")
//    );

//dbContext.Students.AddRange(
//    new Student("Bob"),
//    new Student("Deniz", new DateTime(2005, 06, 28)),
//    new Student("Ann", new DateTime(2005, 01, 01)),
//    new Student("Jafar", new DateTime(2004, 10, 28))
//    );


// FBES_2_22_5_ru
//      Deniz
//      Jafar

// Bob's groups
//      Bob
//      Ann


//dbContext.StudentGroups.Add(new StudentGroup()
//{
//    Student = new Student("Test"),
//    Group = new Group("Test")
//});

// FBES_2_22_5_ru

//var stepGroup = dbContext.Groups.First(g => g.Name == "FBES_2_22_5_ru");

//string[] studentsNames = {
//    "Jafar", "Qasim", "Deniz", "Sadiq", "Elnur"
//};

//var stepStudents = dbContext.Students
//    .Where(s => studentsNames.Contains(s.Name))
//    .ToList();

//var stepStudentsGoups = stepStudents.Select(s => new StudentGroup(s, stepGroup));

//dbContext.AddRange(stepStudentsGoups);


//var bobGroup = dbContext.Groups.First(g => g.Name == "Bob's groups");

//dbContext.StudentGroups.AddRange(
//    new StudentGroup(dbContext.Students.First(s => s.Name.Contains("Bob")), bobGroup),
//    new StudentGroup(dbContext.Students.First(s => s.Name.Contains("Ann")), bobGroup)
//    );



var result = dbContext.StudentGroups
    .Join(dbContext.Students,
   outerKeySelector: sg => sg.StudentId,
   innerKeySelector: s => s.Id,
   resultSelector: (sg, s) => new { sg, s })
    .Join(dbContext.Groups,
   outerKeySelector: sgs => sgs.sg.GroupId,
   innerKeySelector: g => g.Id,
   resultSelector: (sgs, g) => new { StudentGroup = sgs.sg, Student = sgs.s, Group = g })
    .Select(result => new { StudentName = result.Student.Name, GroupName = result.Group.Name })
    .ToList();

foreach (var item in result)
{
    Console.WriteLine(item);
}

dbContext.SaveChanges();