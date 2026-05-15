//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Authentication.ExtendedProtection.Configuration;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS_Begnr
//{
//    internal class studentParameterizedCons
//    {
//        class student
//        {
//            int Sid;
//            string Sname;
//            double Sfee;

//            public student()
//            {
//                Sid = 104;
//                Sname = "Shiva";
//                Sfee = 39000;
//            }

//            public student(int Sid, string Sname, double Sfee)
//            {
//                this.Sid = Sid;
//                this.Sname = Sname;
//                this.Sfee = Sfee;
//            }

//            public void studentDisplay()
//            {
//                Console.WriteLine("Student id is :" + Sid);
//                Console.WriteLine("Student Name is " + Sname);
//                Console.WriteLine("Student fee is {0}", Sfee);
//            }
//        }

//        static void Main(string[] args)
//        {
//            student obj = new student();
//            obj.studentDisplay();
//            student obj1 = new student(102, "ravi", 78000);
//            obj1.studentDisplay();
//        }
//    }
//}

