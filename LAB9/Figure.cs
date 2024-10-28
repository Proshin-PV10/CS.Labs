using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


abstract class Figure
{
    protected string name;
    protected double corner;
         
    abstract public void Return();

    public virtual void Show()
    {
        Console.WriteLine("Фигура: {0}", name);
    }
   
    public Figure(string name,double corner)
    {
        this.corner = corner;
        
    }
    

}


