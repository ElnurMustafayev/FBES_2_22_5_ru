using System.Net;
using System.Net.Http.Json;
using SharedLib.Models;

// WebClient
if (false) {
    var webClient = new WebClient();

    const string address = "https://translate.google.com/?hl=ru&sl=en&tl=ru&text=ambiguous&op=translate";
    var uri = new Uri(address);

    var responseTxt = webClient.DownloadString(uri);

    System.Console.WriteLine(responseTxt);
}

// HttpWebRequest
if(false) {
    const string address = "http://localhost:8080/users";

    HttpWebRequest httpWebRequest = HttpWebRequest.Create(address) as HttpWebRequest;
    httpWebRequest.Method = HttpMethod.Get.Method;

    var response = await httpWebRequest.GetResponseAsync() as HttpWebResponse;
    System.Console.WriteLine(response.ContentType);

    var reader = new StreamReader(response.GetResponseStream());

    var responseTxt = await reader.ReadToEndAsync();

    System.Console.WriteLine(responseTxt);
}

// HttpClient
if(true) {
    const string address = "http://localhost:8080/users";
    HttpClient httpClient = new HttpClient();

    // GET
    if(false) {
        var response = await httpClient.GetAsync(address);
        var responseTxt = await response.Content.ReadAsStreamAsync();
        
        System.Console.WriteLine(responseTxt);
    }

    // POST
    if(true) {
        var newUserJson = new User() {
            Name = "Test",
            Surname = "Testov",
            Age = 17,
        };
        var content = JsonContent.Create(newUserJson);
        var response = await httpClient.PostAsync(address, content);

        var responseTxt = await response.Content.ReadAsStringAsync();

        System.Console.WriteLine($"Content: {responseTxt}");
        System.Console.WriteLine(response);
    }
}