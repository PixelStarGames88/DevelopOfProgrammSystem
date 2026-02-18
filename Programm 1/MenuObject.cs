using System.Xml.Linq;

namespace TaskI;

internal class MenuObject
{
    public List<MenuOperationObject> Operations { get; init; } = null!;

    public MenuObject()
    {
        Operations = new List<MenuOperationObject>();
    }
    public void AddOperation(MenuOperationObject operation)
    {
        Operations.Add(operation);
    }
    public void Summon(string someText)
    {
        Console.WriteLine(someText);
        int i = 0;
        foreach (MenuOperationObject operation in Operations)
        {
            Console.WriteLine(++i + " " + operation.Name);
        }
        Console.WriteLine();
        Console.Write("Введите номер операции - ");
    }
}