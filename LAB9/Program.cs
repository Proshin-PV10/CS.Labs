using System;
using System.Diagnostics.Metrics;



class Program
{
    static void Main()
    {
        StartMeny();
    }

    private static void StartMeny()
    {
        Console.WriteLine("Выберите фигуру:");
        Console.WriteLine("1.Квадрат\n2.Круг\n3.Треугольник\n4.Выход");

        int m = int.Parse(Console.ReadLine());

        switch (m)
        {
            case 1:
                {
                    double A = InputSq();
                    double corner = Corner();
                    Square Sq = new Square(A, "Квадрат", corner);
                    Sq.Show();

                    break;
                }
            case 2:
                {
                    double A = InputCr();
                    Circle Cr = new Circle(A, "Круг", 0);
                    Cr.Show();

                    break;

                }
            case 3:
                {
                    double A, B, C;
                    InputTr(out A, out B, out C);
                    double corner = Corner();
                    Triangle Tr = new Triangle(A, B, C, "Треугольник", corner);
                    Tr.Show();

                    break;
                }
            case 4:
                {
                    break;
                }


        }
    }


    private static void InputTr(out double A, out double B, out double C)
    {
        Console.WriteLine("Введите значение первой стороны треугольника");
        A = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение второй стороны треугольника");
        B = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение стороны третьей треугольника");
        C = double.Parse(Console.ReadLine());
    }

    private static double InputCr()
    {
        Console.WriteLine("Введите значение радиуса окружности");
        double A = double.Parse(Console.ReadLine());
        return A;
    }

    private static double Corner()
    {
        Console.WriteLine("Укажите угол поворота фигуры:");
        double corner = double.Parse(Console.ReadLine())%360;
        return corner;
    }

    private static double InputSq()
    {
        Console.WriteLine("Введите значение стороны квадрата");
        double A = double.Parse(Console.ReadLine());
        return A;
    }

  

}

