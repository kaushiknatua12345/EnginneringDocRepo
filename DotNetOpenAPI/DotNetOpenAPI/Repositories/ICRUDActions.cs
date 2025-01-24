using DotNetOpenAPI.Models;
namespace DotNetOpenAPI.Repositories
{
    /// <summary>
    /// ICURDActions interface is used to define the CRUD operations.
    /// <remarks>
    /// This interface is implemented by the CRUDActions class to handle all the 
    /// CRUD operations.
    /// Currently we have two methods GetEmployees and GetEmployee.
    /// GetEmployees method is used to get all the employees present in the list.
    /// GetEmployee method is used to get the employee with the given id.
    /// </remarks>
    /// </summary>
    public interface ICRUDActions
    {
        public List<EmployeeDB> GetEmployees();
        public EmployeeDB? GetEmployee(int id);
    }
}
