namespace OpenClose
{
    public class EmployeeFullTime
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourValue {get; set;}

        public EmployeeFullTime(string fullname, int hoursWorked, decimal hourValue)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
            HourValue = hourValue;
        }

        public decimal GetSalary()
        {
            EmployeeFullTime employeeFullTime = (EmployeeFullTime)this;
            decimal hourValue = employeeFullTime.HourValue;
            decimal salary = hourValue * employeeFullTime.HoursWorked;
            return (decimal) salary;         
        }
    }
}