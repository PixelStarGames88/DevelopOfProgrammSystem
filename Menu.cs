namespace Sort;

public class Menu
{
    private List<FuntionObject> _functions;

    public Menu(params FuntionObject[] Funtions)
    {
        _functions = new List<FuntionObject>();
        foreach (FuntionObject f in Funtions) { _functions.Add(f); }
        _functions.Add(new FuntionObject("Выход", () => { }));

    }
    public void StartMenu()
    {
        int userChoice = 0;
        do
        {
            Console.WriteLine();
            for (int i = 0; i < _functions.Count; i++)
            {
                Console.WriteLine((i + 1) + " - " + _functions[i].Name);
            }
            Console.Write(Environment.NewLine + "Введите номер операции - ");
            userChoice = IOstreamCoolVersion.WhileNotInt32();
            ChoiceOperation(userChoice);
        } while (userChoice != _functions.Count);
    }
    public void ChoiceOperation(int userChoice)
    {
        if (userChoice < 1 || userChoice > _functions.Count + 1)
        {
            Console.WriteLine(Environment.NewLine + "Операция под номером {0} отсутсвует!!!", userChoice);
        }
        else
        {
            for (int i = 0; i < _functions.Count; i++)
            {
                if (userChoice - 1 == i && _functions[i].SomeFunction != null)
                {
                    _functions[i].SomeFunction();
                }
            }
        }
    }
}
