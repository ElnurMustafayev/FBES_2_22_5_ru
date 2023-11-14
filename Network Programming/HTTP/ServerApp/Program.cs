using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;

HttpListener httpListener = new HttpListener();

// http -> 80
// https -> 443

const int port = 8080;

httpListener.Prefixes.Add($"http://*:{port}/");
httpListener.Start();
System.Console.WriteLine($"Server started on '{port}' port");

while(true) {
    var context = await httpListener.GetContextAsync();

    // \user\get -> 
    // \user\create ->

    //context.Response.ContentType = "text/plain";
    context.Response.ContentType = "application/json";
    
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