using System;

// Абстрактный класс "Геометрическая фигура"
abstract class GeometricFigure
{
    // Виртуальный метод для вычисления площади фигуры
    public abstract double CalculateArea();

    // Виртуальный метод ToString для представления фигуры в виде строки
    public override abstract string ToString();
}

// Интерфейс IPrint
interface IPrint
{
    void Print();
}

// Класс "Прямоугольник"
class Rectangle : GeometricFigure, IPrint
{
    // Свойства для ширины и высоты
    public double Width { get; set; }
    public double Height { get; set; }

    // Конструктор по параметрам "ширина" и "высота"
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Переопределение метода для вычисления площади
    public override double CalculateArea()
    {
        return Width * Height;
    }

    // Переопределение метода ToString
    public override string ToString()
    {
        return $"Rectangle: Width = {Width}, Height = {Height}, Area = {CalculateArea()}";
    }

    // Реализация метода Print() интерфейса IPrint
    public void Print()
    {
        Console.WriteLine(ToString());
    }
}

// Класс "Квадрат"
class Square : Rectangle
{
    // Конструктор по длине стороны
    public Square(double side) : base(side, side)
    {
    }

    // Переопределение метода ToString
    public override string ToString()
    {
        return $"Square: Side = {Width}, Area = {CalculateArea()}";
    }
}

// Класс "Круг"
class Circle : GeometricFigure, IPrint
{
    // Свойство для радиуса
    public double Radius { get; set; }

    // Конструктор по параметру "радиус"
    public Circle(double radius)
    {
        Radius = radius;
    }

    // Переопределение метода для вычисления площади
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    // Переопределение метода ToString
    public override string ToString()
    {
        return $"Circle: Radius = {Radius}, Area = {CalculateArea()}";
    }

    // Реализация метода Print() интерфейса IPrint
    public void Print()
    {
        Console.WriteLine(ToString());
    }
}

// Пример использования
class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle(4.5, 7.9);
        rect.Print();

        Square square = new Square(5);
        square.Print();

        Circle circle = new Circle(3.3);
        circle.Print();
    }
}