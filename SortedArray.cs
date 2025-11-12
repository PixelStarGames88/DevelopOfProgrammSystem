namespace Sort;
public class SortedArray
{
    private List<int> _originalArray;
    private List<int> _sortedArray;
    public int[] GetArray
    {
        get
        {
            return _originalArray.ToArray();
        }
    }
    public int[] GetSortArray
    {
        get
        {
            return _sortedArray.ToArray();
        }
    }
    public SortedArray()
    {
        _originalArray = new List<int>();
        _sortedArray = new List<int>();
    }
    public void ShowArray()
    {
        if (_originalArray.Count != 0)
        {
            Console.WriteLine(Environment.NewLine + "Значеня в исходном массиве:");
            foreach (int i in _originalArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine(Environment.NewLine + "Массив пуст.");
        }
    }
    public void ShowSortArray()
    {
        if (_sortedArray.Count != 0)
        {
            Console.WriteLine(Environment.NewLine + "Значеня в отсортированном массиве:");
            foreach (int i in _sortedArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine(Environment.NewLine + "Массив пуст.");
        }
    }
    public void SaveArray(string path)
    {
        try
        {
            File.WriteAllText(path, string.Join(", ", _originalArray));
            File.AppendAllText(path, Environment.NewLine);
            File.AppendAllText(path, string.Join(", ", _sortedArray));
            Console.WriteLine("Массив успешно сохранен по адресу " + path);
        }
        catch
        {
            Console.WriteLine("Ошибка записи!");
        }
    }
    public void ClearArray()
    {
        _originalArray.Clear();
        _sortedArray.Clear();
    }
    public void AddNumbers(int[] numbers)
    {
        foreach (int number in numbers)
        {
            _originalArray.Add(number);
        }
    }
    public void AddRandomNumbers(uint Count, int FirstValue, int SecondValue)
    {
        Random random = new Random();
        int count = 0;
        while (count < Count)
        {
            if (FirstValue > SecondValue)
                _originalArray.Add(random.Next(SecondValue, FirstValue));
            else if (FirstValue < SecondValue)
                _originalArray.Add(random.Next(FirstValue, SecondValue));
            else
                _originalArray.Add(FirstValue);
            count++;
        }
    }
    public void SortArray()
    {
        int[] SomeArray = _originalArray.ToArray();
        bool moves = true;
        while (moves)
        {
            int count = 0;

            for (int i = 0; i + 1 < SomeArray.Length; i++)
            {
                if (SomeArray[i] > SomeArray[i + 1])
                {
                    int temp = SomeArray[i + 1];
                    SomeArray[i + 1] = SomeArray[i];
                    SomeArray[i] = temp;
                    count++;
                }
            }
            for(int i = SomeArray.Length - 1; i > 0; i--)
            {
                if (SomeArray[i] < SomeArray[i - 1])
                {
                    int temp = SomeArray[i - 1];
                    SomeArray[i - 1] = SomeArray[i];
                    SomeArray[i] = temp;
                    count++;
                }
            }
            moves = count > 0;
        }
        _sortedArray.Clear();
        _sortedArray.AddRange(SomeArray);
    }
}
