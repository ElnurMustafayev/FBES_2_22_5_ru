using ConsoleApp.Entities;
using MongoDB.Driver;

const string connectionString = "mongodb://localhost:27017";

var client = new MongoClient(connectionString);

var database = client.GetDatabase("MyDatabase");

var collection = database.GetCollection<PhoneInfo>("InfoDb");

/*
await collection.InsertOneAsync(new PhoneInfo {
    person = new Person{
        name = "Elnur",
        surname = "Mustafayev"
    },
    phone = "+9945555550"
});
*/


var findAllQuery = collection.Find(phoneInfo => true);

var phoneInfos = await findAllQuery.ToListAsync();

foreach (var phoneInfo in phoneInfos)
{
    System.Console.WriteLine(phoneInfo.person.name);
    System.Console.WriteLine(phoneInfo.person.surname);
    System.Console.WriteLine(phoneInfo.phone);
}