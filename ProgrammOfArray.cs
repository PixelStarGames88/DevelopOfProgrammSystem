namespace Sort;

public class ProgrammOfArray
{
    public SortedArray arrayForSort { get; private set; }
    public ProgrammOfArray()
    {
        arrayForSort = new SortedArray();
    }
    
    public void InputArray()
    {
        Console.WriteLine(Consts.MessageAboutEnd);
        int[] numbers = IOstreamCoolVersion.InputArray();
        arrayForSort.AddNumbers(numbers.ToArray());
    }
    public void InputFormFile()
    {
        Console.Write(Environment.NewLine + "Введите путь - ");
        string path = Console.ReadLine() ?? throw new NullReferenceException();
        int[] numbers = IOstreamCoolVersion.FileOutputArrayInt32(path);
        arrayForSort.AddNumbers(numbers);
    }
    public void FillRandomNubers()
    {
        Console.Write(Environment.NewLine + "Введите количество значений - "); uint number = IOstreamCoolVersion.WhileNotUInt32();
        Console.Write(Environment.NewLine + "Введите первое значение дипапозона - "); int firstValue = IOstreamCoolVersion.WhileNotInt32();
        Console.Write(Environment.NewLine + "Введите второе значение дипапозона - "); int secondValue = IOstreamCoolVersion.WhileNotInt32();
        arrayForSort.AddRandomNumbers(number, firstValue, secondValue);
        arrayForSort.ShowArray();
    }
    public void OutputSortedArray()
    {
        arrayForSort.SortArray(); 
        arrayForSort.ShowSortArray();
    }
    public void Clear()
    {
        arrayForSort.ClearArray(); 
        arrayForSort.ShowArray();
    }
    public void SaveArray()
    {
        if (arrayForSort.GetArray.Length > 0)
        {
            Console.Write(Environment.NewLine + "Введите путь - ");
            string? path = Console.ReadLine() ?? throw new NullReferenceException();
            arrayForSort.SaveArray(path);
        }
        else
        {
            arrayForSort.ShowArray();
        }
    }
}
