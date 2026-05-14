//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS_Begnr
//{
//    internal class StudentClass
//    {
//        class student
//        {
//            int studentid;
//            string sname;
//            int sage;
//            static string collegename = "jntuh";

//            public student(int studentid, string sname, int sage)
//            {
//                this.studentid = studentid;
//                this.sname = sname;
//                this.sage = sage;
//            }
//            public void studentdisplay()
//            {
//                Console.WriteLine("your id " + studentid);
//                Console.WriteLine("your name " + sname);
//                Console.WriteLine("your age " + sage);
//                Console.WriteLine("your collegename :" + collegename);
//            }
//        }
//        static void Main(string[] args)
//        {
//             student[] s = new student[25];

//            for (int i = 0; i < s.Length; i++)
//            {
//                Console.WriteLine("Enter details for student " + (i + 1));

//                Console.WriteLine("enter student id");
//                int id = int.Parse(Console.ReadLine());
//                Console.WriteLine("enter student name");
//                string name = Console.ReadLine();
//                Console.WriteLine("enter student age");
//                int age = int.Parse(Console.ReadLine());
//                s[i] = new student(id, name, age);
//            }
//            Console.WriteLine("student details are:");
//            for (int i = 0; i < s.Length; i++)
//            {
//                s[i].studentdisplay();
//                Console.WriteLine();
//            }
//        }
//    }
//}
