//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS_Begnr
//{
//    internal class EmpCons
//    {
//        class employee
//        {
//            object empid;
//            string empname;
//            int esal;
//            static string emplocation = "hyderabad";

//            public employee()
//            {
//                empid = 101;
//                empname = "nitish";
//                esal = 1000;

//            }
//            public void empsalhike()
//            {
//                double hike = esal * 0.20;
//                Console.WriteLine("Employee hike is " + hike);
//                double newsal = esal + hike;
//                Console.WriteLine("newsalary is " + newsal);
//            }
//            public void employeedisplay()
//            {
//                Console.WriteLine("employee id is " + empid);
//                Console.WriteLine("employee name is " + empname);
//                Console.WriteLine("Employee salary is " + esal);
//                Console.WriteLine("compnany location is " + emplocation);
//            }
//        }
//        static void Main(string[] args)
//        {
//            employee obj = new employee();
//            obj.employeedisplay();
//            obj.empsalhike();
//        }
//    }
//}
