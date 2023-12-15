namespace EmployeeCentralApiRest.Models.DTO
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; } = int.MinValue;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public decimal Salary { get; set; } = decimal.MinValue;
    }
}
