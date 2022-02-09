using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesDiseno.Strateg_y
{
    public class MotoStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("soy una moto y voy con 2 ruedas");
        }
    }
}
