namespace MementoApp;

public class Blog {
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }

    public BlogMemento Save() {
        return new BlogMemento() {
            Id = this.Id,
            Title = this.Title,
            Content = this.Content,
        };
    }

    public void Restore(BlogMemento memento) {
        this.Id = memento.Id;
        this.Title = memento.Title;
        this.Content = memento.Content;
    }

    public override string ToString() {
        return $@"Blog: 
Id: {Id}
Title: {Title}
Content: {Content}
";
    }
}