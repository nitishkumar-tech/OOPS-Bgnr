using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Begnr
{
    internal class StudentClass
    {
        class student
        {
            int studentid;
            string sname;
            int sage;
            static string collegename = "jntuh";
           
            public student (int studentid, string sname, int sage)
            {
                this.studentid= studentid;
                this.sname= sname;
                this.sage = sage;
            }
            public void studentdisplay()
            {
                Console.WriteLine("your id " + studentid);
                Console.WriteLine("your name " + sname);
                Console.WriteLine("your age " + sage);
                Console.WriteLine("your collegename :" + collegename);
            }
        }
        static void Main(string[] args)
        {
            student obj = new student(101, "nitish", 20);
            obj.studentdisplay();
            student obj1 = new student(102, "ravi", 24);
            obj1.studentdisplay();
            student obj2 = new student(103, "raju", 26);
            obj2.studentdisplay();
            student obj3 = new student(104, "rama", 21);
            obj3.studentdisplay();
            student obj4 = new student(105, "vijay", 20);
            obj4.studentdisplay();


        }
    }
}
