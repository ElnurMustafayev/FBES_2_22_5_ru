namespace RoutingApp.Models;

public class MyError
{
    public MyError(string title, string message)
    {
        this.Title = title;
        this.Message = message;
    }

    public int? Priority { get; set; }
    public string Title { get; set; }
    public string Message { get; set; }
}