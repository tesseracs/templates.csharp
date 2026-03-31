namespace TesseracsTemplate;

public sealed class Greeter
{
    public Greeter(string name) => Name = name;

    public string Name { get; }

    public string Greet() => $"Hello from {Name} (C# template)";
}
