using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesDiseno.Singleton
{
    class logWithConstructor
    {
        private static logWithConstructor _instance = null;
        private string _path;
        public static logWithConstructor getInstance(string path)
        {
            if (_instance == null)
            {
                _instance = new logWithConstructor(path);
            }
            return _instance;
        }


        private logWithConstructor(string path){
            this._path = path;
        }

        public void save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }

    }
}
