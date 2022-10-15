using StudentManagement.DataAccessLayer;
using StudentMangement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BussinessLogicLayer
{
    public class EmployeeBussinessLogicLayer
    {
       public  int Id;
       public  String Name;
        public int Age;
        public int AddEmployee(Employee employee)
        {
            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            this.Id = employee.Id;
            this.Name = employee.Name;
            this.Age = employee.Age;
            return employeeDataAccessLayer.AddEmployee(employee);
        }
        public int  UpdateEmployee(Employee employee )
        {
            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            Console.WriteLine("Enter new Employee");
            string new_name = Console.ReadLine();
            Console.WriteLine("Enter new age");
            int new_age = Convert.ToInt32(Console.ReadLine());
            employee.Name = new_name;
            employee.Age = new_age;
            return employeeDataAccessLayer.UpdateEmployee(employee);


        }
        public int DisplayEmployee(Employee employee)
        {
            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            Console.WriteLine("Id:{0} ,Name:{1} ,Age:{2}", employee.Id, employee.Name, employee.Age);
            return employeeDataAccessLayer.DisplayEmployee(employee);
        }
        public int DeleteEmployee(Employee employee)
        {
            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            
            return employeeDataAccessLayer.DeleteEmployee(employee);
        }

    } 
}
