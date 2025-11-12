using Sort;
namespace SortProgramm;
public class MainClass
{
    public static void Main()
    {
        ProgrammOfArray programmOfArray = new ProgrammOfArray();
        Menu menuOfArray = new Menu(new FuntionObject("Ввести значение вручную", () => { programmOfArray.InputArray(); }),
                                  new FuntionObject("Добавить значения из файла", () => { programmOfArray.InputFormFile(); }),
                                  new FuntionObject("Добавить случайные значения", () => { programmOfArray.FillRandomNubers(); }));
        Menu juniorMenu = new Menu(new FuntionObject("Показать отсотрированный массив", () => { programmOfArray.OutputSortedArray(); }),
                                   new FuntionObject("Показать исходный массив", () => { programmOfArray.arrayForSort.ShowArray(); }),
                                   new FuntionObject("Добавить значения в массив", () => { menuOfArray.StartMenu(); }),
                                   new FuntionObject("Очистить массив", () => { programmOfArray.Clear(); }),
                                   new FuntionObject("Сохранить массив", () => { programmOfArray.SaveArray(); }));
        Menu mainMenu = new Menu(new FuntionObject("Запуск", () => { juniorMenu.StartMenu(); }));
        Console.WriteLine(Consts.Message);
        mainMenu.StartMenu();
    }
}