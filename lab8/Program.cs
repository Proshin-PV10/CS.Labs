
using System;

class Program
{

    static void Main()
    {
        Start:
        Triangle tr1, tr2;
        bool whatt = INPUT();
        if (whatt)
        {
            double a = INPUTR();
            tr1 = new Triangle(a);
            OUTPUT1(tr1);
            
        }
        else
        {
            double a, b, c;
            INPUTN(out a, out b, out c);
            tr2 = new Triangle(a, b, c);
            OUTPUT2(tr2);
            
        }
        goto Start;
    }

    private static bool INPUT()
    {
        Console.WriteLine("введите \"1\" если треугольник равносторонний? \nвведите любую клавишу,если нет.");
        string g = Console.ReadLine();
        bool whatt = (g == "1");
        return whatt;
    }
    private static void INPUTN(out double a, out double b, out double c)
    {
        Console.WriteLine("Введите значение первой стороны треугольника");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение второй стороны треугольника");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение стороны третьей треугольника");
        c = double.Parse(Console.ReadLine());
    }
    private static double INPUTR()
    {
        Console.WriteLine("Введите значение стороны треугольника");
        double a = double.Parse(Console.ReadLine());
        return a;
    }
    static void OUTPUT2(Triangle tr)
    {
        if (tr.REAL() == false)
        {
            Console.WriteLine("Данного треугольника не существует");
        }
        else
        {

            Console.WriteLine("Площадь треугольника со сторонами {0}, {1} и {2} равна {3:0.00}", tr.STA(), tr.STB(), tr.STC(), tr.STS());
        }

    }
    static void OUTPUT1(Triangle tr)
    {
        Console.WriteLine("Площадь равностороннего треугольника со стороной {0} равна {1:0.00}", tr.STA(), tr.STS());
    }
}
