using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    class Program
    {
        static void Main(string[] args)
        {
            FitnessPerson javi = new FitnessPerson("javier", 29);
            Console.WriteLine(javi.showData());
            Console.WriteLine(javi.run());
            Console.ReadKey();
        }

      
    }

    public abstract class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string showData()
        {
            return "My name is " + this.name + " I'm " + this.age; 
        }

    }

    public class FitnessPerson: Person
    {
        public FitnessPerson(string name, int age): base(name, age)
        {
          
        }

        public string run()
        {
            return "run";
        }
    }
}
