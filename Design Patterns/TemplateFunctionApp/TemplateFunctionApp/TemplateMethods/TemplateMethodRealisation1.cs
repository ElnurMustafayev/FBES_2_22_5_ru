namespace TemplateFunctionApp.TemplateMethods;

using TemplateFunctionApp.TemplateMethods.Base;

public class TemplateMethodRealisation1 : TemplateMethod {
    protected override void Func1() {
        Console.WriteLine("TemplateMethodRealisation1 class!!!");
    }

    protected override int Func3() {
        int result = base.Func3();
        Console.WriteLine($"old result is: {result}");

        return result + 10;
    }
}