namespace TemplateFunctionApp.TemplateMethods.Base;

public abstract class TemplateMethod {
    public int TemplateFunc() {
        Console.WriteLine("TemplateFunc Start");
        Func1();
        Console.WriteLine(".");
        Func2();
        Console.WriteLine("..");
        int result = Func3();
        Console.WriteLine("...");
        EndMethod();
        Console.WriteLine("TemplateFunc End");

        return result;
    }

    protected abstract void Func1();
    protected virtual void Func2() {
        Console.WriteLine("Func2 base");
    }
    protected virtual int Func3() {
        Console.WriteLine("Log from Func3");
        return 100;
    }
    private void EndMethod() {
        Console.WriteLine("The End.");
    }
}