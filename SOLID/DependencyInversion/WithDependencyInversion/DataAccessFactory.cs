using DependencyInversion.WithDependencyInversion.Interfaces;
using DependencyInversion.WithDependencyInversion.Services;

namespace DependencyInversion.WithDependencyInversion
{
    public class DataAccessFactory
    {
        public static IEmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }
}
