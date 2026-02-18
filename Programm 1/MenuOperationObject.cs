namespace TaskI;
internal class MenuOperationObject
{
    public string Name { get; init; } = null!;
    public event Action SomeOperation = null!;
    public MenuOperationObject(string name)
    {
        Name = name;
    }

    public void Execution() => SomeOperation?.Invoke();
    public void Show() => Console.WriteLine(Name);  
}