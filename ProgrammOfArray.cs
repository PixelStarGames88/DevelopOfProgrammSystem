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
        int[] numbers = IOstreamCS.InputArray();
        arrayForSort.AddNumbers(numbers.ToArray());
        arrayForSort.SortArray();
    }
    public void InputFormFile()
    {
        Console.Write(Environment.NewLine + "Введите путь - ");
        string path = Console.ReadLine() ?? throw new NullReferenceException();
        int[] numbers = IOstreamCS.FileOutputArrayInt32(path);
        arrayForSort.AddNumbers(numbers);
        arrayForSort.SortArray();
    }
    public void FillRandomNubers()
    {
        Console.Write(Environment.NewLine + "Введите количество значений - "); 
        uint number = IOstreamCS.GetUInt32();
        Console.Write(Environment.NewLine + "Введите первое значение дипапозона - "); 
        int firstValue = IOstreamCS.GetInt32();
        Console.Write(Environment.NewLine + "Введите второе значение дипапозона - "); 
        int secondValue = IOstreamCS.GetInt32();
        arrayForSort.AddRandomNumbers(number, firstValue, secondValue);
        arrayForSort.SortArray();
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
