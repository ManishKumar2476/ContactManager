using ContactManager.Core;

namespace ContactManager.Tests;

public class FakeConsole : IConsole
{
    public Queue<string> Input = new();
    public List<string> Output = new();

    public void WriteLine(string text) => Output.Add(text);
    public void Write(string text) => Output.Add(text);
    public string ReadLine() => Input.Dequeue();

}