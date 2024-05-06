namespace OpenClose
{
    public class EmployeePartTime : IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourValue {get; set;}

        public EmployeePartTime(string fullname, int hoursWorked, decimal hourValue)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
            HourValue = hourValue;
        }

        public decimal GetSalary()
        {
            EmployeePartTime employeePartTime = this;
            decimal hourValue = employeePartTime.HourValue;
            decimal salary = hourValue * employeePartTime.HoursWorked;
            if (employeePartTime.HoursWorked > 160) {
                decimal effortCompensation = 5000M;
                int extraDays = employeePartTime.HoursWorked - 160;
                salary += effortCompensation * extraDays;
            }
            return (decimal) salary;
        }
    }
}