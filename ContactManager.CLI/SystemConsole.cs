using ContactManager.Core;
namespace ContactManager.CLI;

public class SystemConsole : IConsole
{
    public void WriteLine(string text) => Console.WriteLine(text);
    public void Write(string text) => Console.Write(text);
    public string ReadLine() => Console.ReadLine() ?? string.Empty;
}
