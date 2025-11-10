namespace Sort;

public class FuntionObject
{
    public string Name { get; private set; }
    public Action SomeFunction;

    public FuntionObject(string name, Action function)
    {
        Name = name;
        SomeFunction = function;
    }

}
