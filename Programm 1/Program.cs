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

        mainMenu.Operations[0].SomeOperation += () => RandomInpiut();
        mainMenu.Operations[1].SomeOperation += () => HandleInpiut();
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

    static public void HandleInpiut()
    {
        double somePointX = 0;
        Console.Write("Введете значение координаты X для точки - ");
        while(!double.TryParse(Console.ReadLine(), out somePointX)) Console.Write("Ошибка ввода! Введите вещественное число - ");
        double somePointY = 0;
        Console.Write("Введете значение координаты Y для точки - ");
        while (!double.TryParse(Console.ReadLine(), out somePointY)) Console.Write("Ошибка ввода! Введите вещественное число - ");

        double PointAX = 0;
        Console.Write("Введете значение координаты X для вершины A треугольника - ");
        while (!double.TryParse(Console.ReadLine(), out PointAX)) Console.Write("Ошибка ввода! Введите вещественное число - ");
        double PointAY = 0;
        Console.Write("Введете значение координаты Y для вершины A треугольника - ");
        while (!double.TryParse(Console.ReadLine(), out PointAY)) Console.Write("Ошибка ввода! Введите вещественное число - ");

        double PointBX = 0;
        Console.Write("Введете значение координаты X для вершины B треугольника - ");
        while (!double.TryParse(Console.ReadLine(), out PointBX)) Console.Write("Ошибка ввода! Введите вещественное число - ");
        double PointBY = 0;
        Console.Write("Введете значение координаты Y для вершины B треугольника - ");
        while (!double.TryParse(Console.ReadLine(), out PointBY)) Console.Write("Ошибка ввода! Введите вещественное число - ");

        double PointCX = 0;
        Console.Write("Введете значение координаты X для вершины C треугольника - ");
        while (!double.TryParse(Console.ReadLine(), out PointCX)) Console.Write("Ошибка ввода! Введите вещественное число - ");
        double PointCY = 0;
        Console.Write("Введете значение координаты Y для вершины C треугольника - ");
        while (!double.TryParse(Console.ReadLine(), out PointCY)) Console.Write("Ошибка ввода! Введите вещественное число - ");

        
        Point somePoint = new(somePointX, somePointY);
        Point PointA = new(PointAX, PointAY);
        Point PointB = new(PointBX, PointBY);
        Point PointC = new(PointCX, PointCY);


        Triangle someTriangle = new Triangle(PointA, PointB, PointC);

        if (somePoint.PointInTrangle(someTriangle))
        {
            Console.WriteLine("Точка в треугольнике");
        }
        else
        {
            Console.WriteLine("Точка не в треугольнике");
        }
    }

    static public void RandomInpiut()
    {
        Random rand = new Random();

        int firstPointX = 0;
        Console.Write("Введете первое значение координаты диапазона по X - ");
        while (!int.TryParse(Console.ReadLine(), out firstPointX)) Console.Write("Ошибка ввода! Введите целое число - ");
        int secondPointX = 0;
        Console.Write("Введете второе значение координаты диапазона по X - ");
        while (!int.TryParse(Console.ReadLine(), out secondPointX)) Console.Write("Ошибка ввода! Введите целое число - ");

        int firstPointY = 0;
        Console.Write("Введете первое значение координаты диапазона по Y - ");
        while (!int.TryParse(Console.ReadLine(), out firstPointY)) Console.Write("Ошибка ввода! Введите целое число - ");
        int secondPointY = 0;
        Console.Write("Введете второе значение координаты диапазона по Y - ");
        while (!int.TryParse(Console.ReadLine(), out secondPointY)) Console.Write("Ошибка ввода! Введите целое число - ");

        Point somePoint = new Point(rand.Next(firstPointX, secondPointX), rand.Next(firstPointY, secondPointY));
        Point PointA = new Point(rand.Next(firstPointX, secondPointX), rand.Next(firstPointY, secondPointY));
        Point PointB = new Point(rand.Next(firstPointX, secondPointX), rand.Next(firstPointY, secondPointY));
        Point PointC = new Point(rand.Next(firstPointX, secondPointX), rand.Next(firstPointY, secondPointY));

        Triangle someTriangle = new Triangle(PointA, PointB, PointC);

        if (somePoint.PointInTrangle(someTriangle))
        {
            Console.WriteLine("Точка с координатами ({0:f2}; {1:f2}) в треугольнике с вершинами в координатах:", somePoint.pointX, somePoint.pointY);
            Console.WriteLine("A ({0:f2}; {1:f2});", PointA.pointX, PointA.pointY);
            Console.WriteLine("B ({0:f2}; {1:f2});", PointB.pointX, PointB.pointY);
            Console.WriteLine("C ({0:f2}; {1:f2}).", PointC.pointX, PointC.pointY);
        }
        else
        {
            Console.WriteLine("Точка с координатами ({0:f2}; {1:f2}) не в треугольнике с вершинами в координатах:", somePoint.pointX, somePoint.pointY);
            Console.WriteLine("A ({0:f2}; {1:f2});", PointA.pointX, PointA.pointY);
            Console.WriteLine("B ({0:f2}; {1:f2});", PointB.pointX, PointB.pointY);
            Console.WriteLine("C ({0:f2}; {1:f2}).", PointC.pointX, PointC.pointY);
        }
    }
}
