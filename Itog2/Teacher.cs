using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itog
{
    internal class Teacher : Person
    {
        private int age;
        private string? fac;
        private string? dol;
        private string? stage;
        public Teacher(string? fac, string dol, string stage, string name, string dateBD) : base(name, dateBD)
        {
            this.stage = stage;
            this.fac = fac;
            this.dol = dol;
            this.name = name;
            this.dateBD = dateBD;
        
        }

        public override void Return()
        {
            return;
        }
        
        public override void Show()
        {
            Console.WriteLine("\tУчитель");
            base.Show();
            Console.WriteLine("Факультет: {0}\nДолжность:{1}\nСтаж:{2}", fac, dol, stage);
        }
       
    }
}
