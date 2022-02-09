using patronesDiseno.Strateg_y;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesDiseno
{
    class Program
    {
        static void Main(string[] args)
        {/*
            var singleton = Singleton.Singleton.Instance;

            //var log = Singleton.Log.Instance;

            //log.save("a");
            //log.save("b");
            //log.save("c");

            var log = Singleton.logWithConstructor.getInstance("hola.txt");

            log.save("a");
            log.save("b");
            log.save("cola");

        */
            var context = new Context(new CarStrategy());
            context.Run();
            context.strategy = new MotoStrategy();
            context.Run();
            Console.ReadKey();
        }
    }
}
