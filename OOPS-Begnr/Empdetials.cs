//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS_Begnr
//{
//    internal class Empdetials
//    {
//        class Employee
//        {
//            int empid;
//            string empname;
//            int empage;
//            string emplocation;
//            static string companyname = "wipro";

//            public Employee(int empid, string empname, int empage, string emplocation)
//            {
//                this.empid = empid;
//                this.empname = empname;
//                this.empage = empage;
//                this.emplocation = emplocation;
//            }
//            public void empdisplay()
//            {
//                Console.WriteLine("your id is :" + empid);
//                Console.WriteLine("your name is :" + empname);
//                Console.WriteLine("your age is :" + empage);
//                Console.WriteLine("your location :" + emplocation);
//                Console.WriteLine("Company name is :" + companyname);
//            }
//        }
//        static void Main(string[] args)
//        {
//            Employee[] emp = new Employee[25];

//            for (int i = 0; i < emp.Length; i++)
//            {
//                Console.WriteLine("enter employee details " + (i + 1));

//                Console.WriteLine("enter your employee id");
//                int id = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("enter your employee name");
//                string ename = Console.ReadLine();
//                Console.WriteLine("enter your employee age");
//                int age = Convert.ToInt32(Console.ReadLine());

//                while (age == 0)
//                {
//                    Console.WriteLine("please enter valid age");
//                    age = Convert.ToInt32(Console.ReadLine());

//                }
//                Console.WriteLine("enter your employee location");
//                string eloc = Console.ReadLine();


//                emp[i] = new Employee(id, ename, age, eloc);
//            }
//            for (int i = 0; i < emp.Length; i++)
//            {
//                emp[i].empdisplay();
//                Console.WriteLine();
//            }
//        }
//    }
//}
