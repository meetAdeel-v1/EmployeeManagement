using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {

        List<Employee> employeeList=new List<Employee>();
        

        public Employee Details(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Employee>  GetAll()
        {
            employeeList.Add(new Employee() { Id = 1, Name = "John", Department = "IT" });
            employeeList.Add(new Employee() { Id = 2, Name = "Carol", Department = "IT" });
            employeeList.Add(new Employee() { Id = 3, Name = "Jeremey", Department = "IT" });
            return employeeList;
        }
    }
}
