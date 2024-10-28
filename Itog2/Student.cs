using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itog
{
    internal class Student : Person
    {
        private string? fac;
        private string? gruppa;
        public Student(string? fac, string gruppa, string name, string dateBD) : base(name, dateBD)
        {
            this.fac = fac;
            this.gruppa = gruppa;
            this.name = name;
            this.dateBD = dateBD;
           
        }

        public override void Return()
        {
            return;
        }
        public override void Show()
        {
            Console.WriteLine("\tСтудент");
            base.Show();
            Console.WriteLine("Факультет: {0}\nГруппа:{1}", fac, gruppa);
        }
    }
}
