namespace InheritanceApp;

public enum ExceptionStatus {
    info, warning, error
}

public class ExceptionWithStatus : Exception {
    public readonly ExceptionStatus Status;

	public ExceptionWithStatus(ExceptionStatus status) {
        this.Status = status;
    }
}