﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesDiseno.Singleton
{
    public class Log
    {
        private readonly static Log _instance = new Log();
        private string _path = "Log.txt";
        public static Log Instance
        {
            get
            {
                return _instance;
            }
        }

        private Log()
        {

        } 

        public void save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine); 
        }
    }
}
