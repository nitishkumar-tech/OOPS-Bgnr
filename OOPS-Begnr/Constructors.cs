using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Begnr
{
    internal class Constructors
    {
        class myclass

        {
            int a, b;
            public myclass()
            {
                 a = 10;
                 b = 20;
                Console.WriteLine("constructor is called");
            }
            public void greet()
            {
                Console.WriteLine("a value is {0}", a);
                Console.WriteLine("b value is {0}", b);

            }
            public int add()
            {
                return a + b;
                
            }
            public int sub()
            {
                return a - b;
                
            }
            public int mul()
            {
                return a * b;
            }
            public int div()
            {
                return a / b;
            }

            static void Main(string[] args)
            {
                myclass obj = new myclass();
                obj.greet();
                int res = obj.add();
                Console.WriteLine("addition result is " + res);
                int sub = obj.sub();
                Console.WriteLine("sub result is " + sub);
                int mul = obj.mul();
                Console.WriteLine("mul result is " + mul);
                int div = obj.div();
                Console.WriteLine("div result is " + div);
            }
        }
    }
}