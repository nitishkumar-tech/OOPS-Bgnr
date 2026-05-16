using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Begnr
{
    internal class stdcons
    {
        class student
        {
            int stdid;
            string sname;
            int sage;

            public student(int stdid, string sname, int sage)
            {
                this.stdid = stdid;
                this.sname = sname;
                this.sage = sage;
                if (sage >= 18 && sage <= 60)
                {
                    Console.WriteLine("your age is  " + sage);
                }
                else
                {
                    Console.WriteLine("Not a Valid Age");
                }
            }
            public void studentdisplay()
            {
                Console.WriteLine("your id is " + stdid);
                Console.WriteLine("your name is " + sname);
            }
        }
        static void Main(string[] args)
        {
            student obj = new student(101, "rama", 10);
            obj.studentdisplay(); 
            student obj1 = new student(102, "ravi", 18);
            obj1.studentdisplay();
            student obj2 = new student(102, "raju", 65);
            obj2.studentdisplay();
            student obj3 = new student(102, "rakesh", 60);
            obj3.studentdisplay();
        }
    }
}
