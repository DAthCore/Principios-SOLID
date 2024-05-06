namespace Liskov
{
    public class EmployeeFullTime : EmployeeExtraHours
    {
        public EmployeeFullTime(string fullname, int hoursWorked, int extrahours) : base(fullname, hoursWorked, extrahours)
        {
        }
    }
}