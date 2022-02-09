using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesDiseno.Strateg_y
{
    public class CarStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("soy un carro y voy con 4 ruedas.");
        }
    }
}
