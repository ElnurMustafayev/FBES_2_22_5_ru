using SingletonApp.Models;

namespace SingletonApp.Pages.Base;

public abstract class Page {
    virtual public void Print() {
        Console.WriteLine(this.GetType().Name + '\n');
    }
}