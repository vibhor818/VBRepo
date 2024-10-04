using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Data.Model
{
    public class EmpList
    {
        List<Employee> employees;
        public EmpList()
        {
            employees = new List<Employee>();
        }
        public void InsertEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
