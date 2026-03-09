namespace SPBSIT__TU_;

public class ArrayObject
{
    public int[] SomeArray { get; private set; }
    public ArrayObject()
    {
        SomeArray = new int[0];
    }
    public bool SetStringArray(string numbers)
    {
        try
        {
            SomeArray = numbers.Split(' ').Select(n => int.Parse(n)).ToArray();
            return true;
        }
        catch
        {
            return false;
        }
    }
    public string GetArrayAsString() => string.Join(' ', SomeArray);
    public string GetSortedArrayAsString(string Sort)
    {
        if (Sort == "Shaker")
            return string.Join(' ', SortArrayByShaker());
        else
            return string.Join(' ', ShallsSort());
    }
    public void GenerateArray(int firstNumber, int lastNumber, uint quantity)
    {
        if(firstNumber > lastNumber)
        {
            int tmp = firstNumber;
            firstNumber = lastNumber;
            lastNumber = tmp;
        }
        Random random = new Random();
        int[] NewArray = new int[quantity + SomeArray.Length];
        for (int i = 0;i < SomeArray.Length; i++)  NewArray[i] = SomeArray[i];
        for (int i = SomeArray.Length; i < NewArray.Length; i++) NewArray[i] = random.Next(firstNumber, lastNumber);
        SomeArray = NewArray;
    }
    public int[] SortArrayByShaker()
    {
        int[] SortedArray = new int[SomeArray.Length];
        
        for(int i = 0; i<SomeArray.Length; i++) SortedArray[i] = SomeArray[i];
        
        int count = 0;
        bool move = true;
        while(move)
        {
            count = 0;
            for (int i = 1; i < SortedArray.Length; i++)
            {
                if (SortedArray[i - 1] > SortedArray[i])
                {
                    int tmp = SortedArray[i - 1];
                    SortedArray[i - 1] = SortedArray[i];
                    SortedArray[i] = tmp;
                    count++;
                }
            }
            for (int i = SortedArray.Length - 1; i > 0; i--)
            {
                if (SortedArray[i] < SortedArray[i - 1])
                {
                    int tmp = SortedArray[i - 1];
                    SortedArray[i - 1] = SortedArray[i];
                    SortedArray[i] = tmp;
                    count++;
                }
            }
            move = (count > 0);
        }
        return SortedArray;
    }
    public void ClearArray()
    {
        SomeArray = new int[0];
    }
    public int[] ShallsSort()
    {
        int[] SortedArray = new int[SomeArray.Length];
        for (int k = 0; k < SomeArray.Length; k++) SortedArray[k] = SomeArray[k];

       
        int i = SortedArray.Length - 1;
        for (; i >= 0; i--)
        {
            for(int j = 0; j < SortedArray.Length - i; j++)
            {
                if (SortedArray[j] > SortedArray[j + i])
                {
                    int tmp = SortedArray[j + i];
                    SortedArray[j + i] = SortedArray[j];
                    SortedArray[j] = tmp;
                }
            }
        }
        return SortedArray;
    }


    public int[] ShallsSort(out int swapCount, out int compareCount)
    {
        int[] SortedArray = new int[SomeArray.Length];
        for (int k = 0; k < SomeArray.Length; k++) SortedArray[k] = SomeArray[k];

        swapCount = 0;
        compareCount = 0;
        int i = SortedArray.Length - 1;
        for (; i >= 0; i--)
        {
            for (int j = 0; j < SortedArray.Length - i; j++)
            {
                if (SortedArray[j] > SortedArray[j + i])
                {
                    int tmp = SortedArray[j + i];
                    SortedArray[j + i] = SortedArray[j];
                    SortedArray[j] = tmp;

                    swapCount++;
                }
                compareCount++;
            }
        }
        return SortedArray;
    }

    public int[] SortArrayByShaker(out int swapCount, out int compareCount)
    {
        int[] SortedArray = new int[SomeArray.Length];

        for (int i = 0; i < SomeArray.Length; i++) SortedArray[i] = SomeArray[i];

        swapCount = 0;
        compareCount = 0;

        int count = 0;
        bool move = true;
        while (move)
        {
            count = 0;
            for (int i = 1; i < SortedArray.Length; i++)
            {
                compareCount++;
                if (SortedArray[i - 1] > SortedArray[i])
                {
                    int tmp = SortedArray[i - 1];
                    SortedArray[i - 1] = SortedArray[i];
                    SortedArray[i] = tmp;
                    count++;

                    swapCount++;
                }
            }
            for (int i = SortedArray.Length - 1; i > 0; i--)
            {
                compareCount++;
                if (SortedArray[i] < SortedArray[i - 1])
                {
                    int tmp = SortedArray[i - 1];
                    SortedArray[i - 1] = SortedArray[i];
                    SortedArray[i] = tmp;
                    count++;

                    swapCount++;
                }
            }
            move = (count > 0);
        }
        return SortedArray;
    }
}