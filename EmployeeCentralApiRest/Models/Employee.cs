namespace EmployeeCentralApiRest.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
       
        // Constructor con todos los parámetros
        public Employee(int employeeId, string firstName, string lastName, decimal salary)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }
    }
}
