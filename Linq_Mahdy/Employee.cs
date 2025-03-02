using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Mahdy
{
    internal class Employee
    {
         public string Name { get; set; }   
         public int Age { get; set; }
         public int Salary { get; set; }
        public int DeptID { get; }

        public Employee(string name, int age, int salary, int DeptID)
        {
           Name= name;
           Age = age;
           Salary = salary;
            this.DeptID = DeptID;
        }

        public Employee() { }

    }
}
