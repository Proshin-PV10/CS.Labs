using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Itog
{
    internal class Admin : Person
    {
        private string? Lab;
        public Admin(string? Lab, string name, string dateBD) : base(name, dateBD)
        {
            this.Lab = Lab;
            this.name = name;
            this.dateBD = dateBD;
            
        }

        public override void Return()
        {
            return;
        }
        public override void Show()
        {
            Console.WriteLine("\tАдминистратор");
            base.Show();
            Console.WriteLine("Лаборатория: {0}", Lab);
        }
   
       
    }
}
