using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itog
{
    internal class Manager:Person
    {
        
        private string? fac;
        private string? dol;
        public Manager(string? fac, string dol, string name, string dateBD) : base(name, dateBD)
        {
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
            Console.WriteLine("\tМенеджер");
            base.Show();
            Console.WriteLine("Факультет: {0}\nДолжность:{1}", fac,dol);
        }




    }
}

