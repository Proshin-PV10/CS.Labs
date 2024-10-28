using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class Triangle : Figure
    {
       private double A; 
       private double B; 
       private double C;      
       private double P;
       private double S;

        public Triangle(double A, double B, double C, string name, double corner) : base(name, corner)
        {   this.name = name;
            this.A = A;
            this.B = B;
            this.C = C;
            this.corner=corner;
        

    }
      
        public override void Show()
        {
            if (REAL() == false)
            {
                Console.WriteLine("Данного треугольника не существует");
            }
            else
            {
                P = A + B + C;
                S = Math.Sqrt((P / 2) * ((P / 2) - A) * ((P / 2) - B) * ((P / 2) - C));
                base.Show();
                Console.WriteLine("Сторогна А: {0}\nСторона B: {1}\nСторогна C: {2}\nПериметр: {3}\nПлощадь: {4:0.##}\nУгол поворота: {5}", A, B, C, P, S, corner);
            }
          
        }
    
   
       
        public override void Return() 
        {
        return;
        }
        public bool REAL()
    {
        if (A <= B + C && B <= A + C && C <= A + B)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}

