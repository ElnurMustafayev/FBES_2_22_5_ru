namespace TokenValidatorMiddlewareApp.Exceptions;

public class NotFoundException : Exception
{
    private readonly string entityName;

    public NotFoundException(string entityName)
    {
        this.entityName = entityName;
    }

    public override string Message => $"{this.entityName} not found!";
}