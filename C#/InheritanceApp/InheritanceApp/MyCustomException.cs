namespace InheritanceApp;

public class MyCustomException : Exception {
    public readonly string Description;

	public MyCustomException(string description) {
        this.Description = description;
    }
}