using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Begnr
{
    internal class StudentMarks
    {
    }
    class student
    {
        int studentid;
        string sname;
        int sage;
        int m1, m2, m3;
        static string collegename = "jntuh";

        public student(int studentid, string sname, int sage)
        {
            this.studentid = studentid;
            this.sname = sname;
            this.sage = sage;
        }
        public student(int studentid, string sname, int sage, int m1, int m2, int m3)
        {
            this.studentid = studentid;
            this.sname = sname;
            this.sage = sage;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }

        public void studentdisplay()
        {
            Console.WriteLine("your id " + studentid);
            Console.WriteLine("your name " + sname);
            Console.WriteLine("your age " + sage);
            Console.WriteLine("your collegename :" + collegename);
        }

        public void studentdisplaymarks()
        {
            int total = m1 + m2 + m3;
            Console.WriteLine("Total marks: " + total);
            int avg = (m1 + m2 + m3) / 3;
            Console.WriteLine("Average marks: " + avg);
        }
        static void Main(string[] args)
        {
            student[] s = new student[20];

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Enter details for student " + (i + 1));

                Console.WriteLine("enter student id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter student name");
                string name = Console.ReadLine();
                Console.WriteLine("enter student age");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("enter M1 marks");
                int m1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter M2 marks");
                int m2 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter M3 marks");
                int m3 = int.Parse(Console.ReadLine());
                s[i] = new student(id, name, age, m1, m2, m3);
            }
            
            Console.WriteLine("student details are:");
            for (int i = 0; i < s.Length; i++)
            {
                s[i].studentdisplay();
                s[i].studentdisplaymarks();
                Console.WriteLine();
            }
        }
    }
}

