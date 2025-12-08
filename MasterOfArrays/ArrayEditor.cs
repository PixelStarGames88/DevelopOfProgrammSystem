namespace MasterOfArrays;
public class ArrayEditor
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
    public ArrayEditor()
    {
        _originalArray = new List<int>();
        _sortedArray = new List<int>();
    }
    public void ClearArray()
    {
        _originalArray.Clear();
        _sortedArray.Clear();
    }
    public bool AddNumbersFromString(string Numbers)
    {
        if (Numbers == GetStringSortedArray() || Numbers == GetStringSourceArray())
        {
            return true;
        }

        ClearArray();
        try
        {
            foreach (int number in Numbers.Split(' ').Select(x => Convert.ToInt32(x)).ToArray())
            { 
                if (_originalArray.Count > Constants.QUANTITY_LIMIT) break;
                _originalArray.Add(number);
            }
            SortArray();
            return true;
        }
        catch
        {
            return false;
        }
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
    public string GetStringSourceArray()
    {
        return string.Join(' ', _originalArray);
    }
    public string GetStringSortedArray()
    {
        SortArray();
        return string.Join(' ', _sortedArray);
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
            for (int i = SomeArray.Length - 1; i > 0; i--)
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
