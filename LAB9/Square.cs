using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class Square : Figure
{
    private double A;
    private double P;
    private double S;


    public Square(double A, string name, double corner) : base(name,corner)
    {
        this.corner = corner;
        this.name = name;
        this.A = A;
        
        P = 4*A;
        S = A*A;

    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine("Сторона:{0}\nПериметр:{1}\nПлощадь:{2:0.##}\nУгол поворота: {3}", A, P, S,corner);
        
    }



    public override void Return() 
    {
        return;
    }

}

