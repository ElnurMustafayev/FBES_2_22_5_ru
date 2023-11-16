using System.Net;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using ServerApp.Models;


static string GetHtml<T>(IEnumerable<T> collection)
{
    StringBuilder sb = new StringBuilder(100);

    Type itemType = typeof(T);
    var props = itemType.GetProperties();

    foreach (var item in collection)
    {
        sb.Append("<ul>");
        foreach (var itemProp in props)
        {
            var value = itemProp.GetValue(item);
            sb.Append($"<li>{itemProp.Name}: {value}</li>");
        }
        sb.Append("</ul>");
    }

    return sb.ToString();
}


HttpListener httpListener = new HttpListener();

// http -> 80
// https -> 443

const int port = 8080;

httpListener.Prefixes.Add($"http://*:{port}/");
httpListener.Start();
System.Console.WriteLine($"Server started on '{port}' port");

while (true)
{
    var context = await httpListener.GetContextAsync();
    var rawUrl = context.Request.RawUrl.Trim('/').ToLower();
    using var writer = new StreamWriter(context.Response.OutputStream);
    var rawItems = rawUrl.Split('/');

    if (rawItems.First() == "users")
    {
        // GET
        if (context.Request.HttpMethod == HttpMethod.Get.Method)
        {
            context.Response.ContentType = "text/html";
            var usersJson = File.ReadAllText("Data/users.json");
            var users = JsonSerializer.Deserialize<IEnumerable<User>>(
                usersJson,
                options: new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            if (rawItems.Last() != "users")
            {
                var name = rawItems.Last();

                var foundByNameUsers = users.Where(u => u.Name != null && u.Name.ToLower().Contains(name));

                if (foundByNameUsers != null && foundByNameUsers.Any())
                {
                    var foundByNameUsersHtml = GetHtml(foundByNameUsers);

                    context.Response.StatusCode = 200;
                    await writer.WriteLineAsync(foundByNameUsersHtml);
                }
                else
                {
                    context.Response.StatusCode = 404;
                    await writer.WriteLineAsync($"User not Found by name: '{name}'!");
                }
            }

            else
            {
                var usersHtml = GetHtml(users);

                await writer.WriteLineAsync(usersHtml);
            }
        }

        // POST
        else if (context.Request.HttpMethod == HttpMethod.Post.Method)
        {
            context.Response.ContentType = "plain/text";
            var reader = new StreamReader(context.Request.InputStream);
            var newUserJson = await reader.ReadToEndAsync();

            var newUser = JsonSerializer.Deserialize<User>(newUserJson, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if(newUser is null || string.IsNullOrWhiteSpace(newUser.Name)) {
                context.Response.StatusCode = 400;
            }
            else {
                context.Response.StatusCode = 201;
                await writer.WriteLineAsync($"User {newUser?.Name} created with id {Random.Shared.Next()}");
            }
        }
    }

    else
    {
        context.Response.StatusCode = 404;
        await writer.WriteLineAsync("Not Found 404!");
    }
}



/*
while(true) {
    var context = await httpListener.GetContextAsync();

    // \user\get -> 
    // \user\create ->

    //context.Response.ContentType = "text/plain";
    //context.Response.ContentType = "application/json";
    
    using var writer = new StreamWriter(context.Response.OutputStream);
    //await writer.WriteLineAsync($"{context.Request.RawUrl}");

    // var json = JsonSerializer.Serialize(new {Name = "Test"});
    // await writer.WriteLineAsync(json);

    //await writer.WriteLineAsync("<h1>Hello World!</h1>");
    await writer.WriteLineAsync("Hello World!");

    // content-type
    // method-type
    // status-code
}
*/