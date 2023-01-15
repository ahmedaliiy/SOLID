using DependencyInversion.WithDependencyInversion.Interfaces;

namespace DependencyInversion.WithDependencyInversion.Services
{
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Pranaya",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }
    }
}
