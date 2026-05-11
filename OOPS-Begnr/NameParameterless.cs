using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Begnr
{
    internal class NameParameterless
    {
        class myclass
        {
            public void display()
            {
                Console.WriteLine("enter your name");
                string name = Console.ReadLine();
                Console.WriteLine("Hello " + name);
            }
        }
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            obj.display();
        }
    }
}

