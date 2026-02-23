//ProgramObject.cs
namespace TaskI;
public class ProgramObject
{
    static public void HandleInpiut()
    {
        double somePointX = 0;
        Console.Write("Введете значение координаты X для точки - ");
        while (!double.TryParse(Console.ReadLine(), out somePointX)) Console.Write("Ошибка ввода! Введите вещественное число - ");
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

        if (someTriangle.IsPoint()) { Console.WriteLine("Точки образуют точку!! Не треугольник!!!"); return; }
        if (someTriangle.IsLine()) { Console.WriteLine("Точки образуют прямую!! Не треугольник!!!"); return; }
        somePoint.PointInTrangle(someTriangle);
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

        Triangle someTriangle = Triangle.GenerateRandomTriangle(firstPointX, secondPointX, firstPointY, secondPointY);
        Point somePoint = Point.GenerateRandomPoint(firstPointX, secondPointX, firstPointY, secondPointY);

        if (someTriangle.IsPoint()) { Console.WriteLine("Точки образуют точку!! Не треугольник!!!"); return; }
        if (someTriangle.IsLine()) { Console.WriteLine("Точки образуют прямую!! Не треугольник!!!"); return; }
        somePoint.PointInTrangle(someTriangle);
    }
}