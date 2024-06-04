using ScroogeApp.Core.Services;

namespace ScroogeApp.Infrastructure.Services;

public class TalkingConsoleService : ITalkingService
{
    public void Say(string message)
    {
        System.Console.WriteLine($"{nameof(TalkingConsoleService)}: '{message}'");
    }
}