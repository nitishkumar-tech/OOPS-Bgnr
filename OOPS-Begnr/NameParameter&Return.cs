using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Begnr
{
    internal class NameParameter_Return
    {
        class myclass
        {
            public string display(string name)
            {
                
                string c;
                c = name;
                return c;
            }
        }
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            string result = obj.display("nitish");
            Console.WriteLine("Your name is {0}", result);
        }
    }
}
