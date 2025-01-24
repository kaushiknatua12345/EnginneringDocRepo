namespace DotNetOpenAPI.Models
{
    /// <summary>
    /// EmployeeDB class is used to define the structure of the employee details.
    /// It contains the properties Id, Name, Department, and Email.
    /// </summary>
    public class EmployeeDB
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
    }
}
