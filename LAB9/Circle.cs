using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class Circle : Figure
{
    private double A;
    private double P;
    private double S;

    public Circle(double A, string name, double corner) : base(name, corner)
    {
        this.name = name;
        this.A = A;
        double pi = 3.14;
        P = 2 * pi * A;
        S = pi * A * A;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine("Радиус: {0}\nПериметр: {1:0.##}\nПлощадь: {2:0.##}", A, P, S);
    }

    public override void Return()
    {
        return;
    }
}

