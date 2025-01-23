using DotNetOpenAPI.Models;

namespace DotNetOpenAPI.Repositories
{
/// <summary>
/// CrudActions class is used to handle all the CRUD operations.
/// It implements the ICRUDActions interface.
/// It contains two methods GetEmployees and GetEmployee.
/// It contains a static list of employees to store the employee details.
///</summary>
    public class CRUDActions : ICRUDActions
    {
        public static List<EmployeeDB> employees = new List<EmployeeDB>()
        {
            new EmployeeDB() { Id = 1, Name = "John", Department = "IT", Email = "john@hyland.com" },
            new EmployeeDB() { Id = 2, Name = "Jane", Department = "HR", Email = "jane@hyland.com" }
        };       

        /// <summary>
        /// EmployeeDB Method is used to get the employee with the given id.
        /// It returns the employee with the given id if it exists in the list.
        /// If the employee with the given id does not exist in the list, it returns null.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public EmployeeDB? GetEmployee(int id)
        {
           // Find the employee with the given id
                var find= employees.Find(e => e.Id == id);
                if(find == null)
                {
                return null;
                }
                return find;
        }
        /// <summary>
        /// GetEmployees method is used to get all the employees present in the list.
        /// If no records are present under EmployeeList, it will return null.
        /// </summary>
        /// <returns></returns>
        public List<EmployeeDB> GetEmployees()
        {
           if(employees.Count == 0)
            {
            return null;
            }
            return employees;
        }
    }
}
