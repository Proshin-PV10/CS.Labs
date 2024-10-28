using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Itog
{

    abstract class Person(string name, string dateBD) : IProfsoius
    {
        protected string? name = name;
        protected string? dateBD = dateBD;
        public bool Status { get; set; }

        abstract public void Return();

       
       public virtual void Show()
        {
            int age = CalculateAge();
            Console.WriteLine("Фамилия: {0}\nДата рождения:{1}\nВозраст:{2}", name, dateBD, age);
        }
        public int CalculateAge()
        {
            DateTime dt = DateTime.Parse(dateBD);
            DateTime today = DateTime.Now;
            int age = today.Year - dt.Year;
            if (dt > today.AddYears(-age))
                age--;
            return age;
        }
        public void PS()
        {
            if (Status == true)
                Console.WriteLine("{0} находится в профсоюзе", name);
            else Console.WriteLine("{0} не находится в профсоюзе", name);
            Console.WriteLine("__________________________________________________________");
        }
    }
}
