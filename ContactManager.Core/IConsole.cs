
namespace ContactManager.Core;

public interface IConsole
{
    void WriteLine(string text);
    void Write(string text);
    string ReadLine();
}