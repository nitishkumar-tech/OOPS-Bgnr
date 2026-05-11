using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Begnr
{
    internal class Parameterless
    {
        class myclass
        {
            public void greet()
            {
                Console.WriteLine("Hello welcome to methods");
            }

            public void add()
            {
                int a = 10;
                int b = 30;
                int c = a + b;
                Console.WriteLine("Addition of two numbers is : {0}", c);
            }
        }

        static void Main(string[] args)
        {
            myclass obj = new myclass();
            obj.greet();
            obj.add();
        }
    }
}
