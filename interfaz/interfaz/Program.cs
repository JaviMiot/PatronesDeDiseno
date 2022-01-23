using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            var pato1 = new Pato();
            var pato2 = new Pato();
            var pato3 = new Pato();
            var pato4 = new Pato();
            var pato5 = new Pato();

            List<IVolador> patos = new List<IVolador>();

            patos.Add(pato1);
            patos.Add(pato2);
            patos.Add(pato3);
            patos.Add(pato4);
            patos.Add(pato5);

            void Avolar(List<IVolador> aves)
            {
                foreach (var ave in aves)
                {
                    ave.volar();
                }
            }


            Avolar(patos);

            Console.ReadKey();

        }
    }

 
    interface IVolador
    {
        void volar();
    }

    interface ICaminador
    {
        void caminar();
    }

    public class  Pato: IVolador, ICaminador
    {
        public void volar()
        {
            Console.WriteLine("pato vuela");
        }

        public void caminar()
        {
            Console.WriteLine("pato camina");
        }
    }
}
