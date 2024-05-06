namespace OpenClose
{
    public class EmployeeContractor : IEmployee
    {
        public string Fullname {get; set;}
        public int HoursWorked {get; set;}
        public decimal HourValue {get; set;}

        public EmployeeContractor(string fullname, int hoursWorked, decimal hourValue)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
            HourValue = hourValue;
        }

        public decimal GetSalary()
        {
            EmployeeContractor employeeContractor = this;
            decimal hourValue = employeeContractor.HourValue;
            decimal salary = hourValue * employeeContractor.HoursWorked;
            return (decimal) salary;
        }

    }
}