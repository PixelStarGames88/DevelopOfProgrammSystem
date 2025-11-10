namespace Sort;

public static class IOstreamCoolVersion
{
    public static int WhileNotInt32()
    {
        int output;

        while (!int.TryParse(Console.ReadLine(), out output))
        {
            Console.Write("Ошибка ввода! Введите целое число - ");
        }

        return output;
    }
    public static uint WhileNotUInt32()
    {
        uint output;

        while (!uint.TryParse(Console.ReadLine(), out output))
        {
            Console.Write("Ошибка ввода! Введите целое неотрицательное число - ");
        }

        return output;
    }
    public static int[] InputArray()
    {
        List<int> numbers = new List<int>();
        string number = string.Empty;
        while (number != "!")
        {
            try
            {
                number = Console.ReadLine() ?? throw new NullReferenceException();
                if (number != "!") numbers.Add(Convert.ToInt32(number));
            }
            catch
            {
                Console.WriteLine("Не получилось добавть значение.");
            }
        }
        return numbers.ToArray();
    }
    public static int[] FileOutputArrayInt32(string path)
    {
        return File.ReadAllText(path).Substring(0, File.ReadAllText(path).IndexOf(Environment.NewLine)).Split(", ").Select(x => Convert.ToInt32(x)).ToArray();
    }
}
