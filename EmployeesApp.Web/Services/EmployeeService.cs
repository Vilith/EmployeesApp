using EmployeesApp.Web.Models;

namespace EmployeesApp.Web
{
    public class EmployeeService
    {
        private List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "John Doe", Email = "email@email.com" },
            new Employee { Id = 2, Name = "Jane Smith", Email = "mail@mail.com" },
            new Employee { Id = 3, Name = "Sam Brown", Email = "imäjl@imäjl.com" },
        };

        public void Add(Employee employee)
        {
            if (employees.Count == 0)
            {
                employee.Id = 1;
            }
            else
            {
                employee.Id = employees.Max(e => e.Id) + 1;
            }
            employees.Add(employee);
        }
        
        public Employee[] GetAll()
        {
            return employees.ToArray();
        }

        public Employee? GetById(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }


    }
}
