namespace TaskI;

internal class Programm
{
    static void Main(string[] args)
    {
        int userChoice = 0;

        MenuObject mainMenu = new MenuObject();
        mainMenu.AddOperation(new("Ввод случайных значений"));
        mainMenu.AddOperation(new("Ввод с клавиатуры"));
        mainMenu.AddOperation(new("Выход"));

        mainMenu.Operations[0].SomeOperation += () => ProgramObject.RandomInpiut();
        mainMenu.Operations[1].SomeOperation += () => ProgramObject.HandleInpiut();
        mainMenu.Operations[2].SomeOperation += () => Console.WriteLine("До свидания! До новых встреч!!!");

        Console.WriteLine(Consts.Message);
        do
        {
            do
            {
                mainMenu.Summon("");
                while (!int.TryParse(Console.ReadLine(), out userChoice))
                {
                    Console.Write("Ошибка ввода! Введите целое число - ");
                }
                if (userChoice - 1 < 0 || userChoice - 1 >= mainMenu.Operations.Count)
                    Console.WriteLine("Ошибка ввода! Операция отсутствует!");
            } while (userChoice - 1 < 0 || userChoice - 1 >= mainMenu.Operations.Count);

            mainMenu.Operations[userChoice - 1].Execution();
        } while (userChoice != 3);
    }
}