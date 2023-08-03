namespace MementoApp;

public class BlogCaretaker {
    private int loadCounter = 0;
    private List<BlogMemento> mementos = new List<BlogMemento>();

    private readonly Blog originator;

    public BlogCaretaker(Blog originator) {
        this.originator = originator;
    }

    public void Save() {
        loadCounter = 0;
        var memento = this.originator.Save();
        this.mementos.Add(memento);
    }

    public void Load() {
        if (this.mementos == null)
            return;

        var currentMemento = this.mementos.SkipLast(loadCounter++).LastOrDefault();

        if (currentMemento == null)
            return;

        this.originator.Restore(currentMemento);
    }
}