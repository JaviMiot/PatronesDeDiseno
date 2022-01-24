using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesDiseno.Singleton
{
    class Singleton
    {
        private readonly static Singleton _instance = new Singleton();

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }

        //bloqueas ek cosntructor
        private Singleton()
        {

        }
    }
}
