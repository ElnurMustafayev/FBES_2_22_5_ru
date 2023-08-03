namespace MementoApp;

public class BlogMemento {
    public readonly DateTime CreationDate;

    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }


    public BlogMemento() {
        this.CreationDate = DateTime.Now;
    }
}