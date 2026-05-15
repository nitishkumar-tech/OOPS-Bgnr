using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Begnr
{
    internal class ParameterCons_2
    {
        class Employee
        {
            int Eid;
            string Ename;
            double Esal;


            public Employee()
            {
                Eid = 101;
                Ename = "Rama";
                Esal = 30000;
            }

            public Employee(int eid, string ename, double esal)
            {
                Eid = eid;
                Ename = ename;
                Esal = esal;
            }

            public void  EmployeeDisplay()
            {
                Console.WriteLine("employee id is " + Eid); 
                Console.WriteLine("employee name is " + Ename);
                Console.WriteLine("employee salary is " + Esal);

            }
        }
        static void Main(string[] args)
        {
            Employee obj= new Employee();
            obj.EmployeeDisplay();
            Employee obj1 = new Employee(102, "ravi", 45000);
            obj1.EmployeeDisplay();
        }

    }
}
