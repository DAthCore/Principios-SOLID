namespace Liskov {

    public abstract class EmployeeExtraHours : Employee
    {
        public int ExtraHours {get;set;}

        public EmployeeExtraHours(string fullname, int hoursWorked, int extrahours) : base(fullname, hoursWorked){
            ExtraHours = extrahours;
        }

        public override decimal CalculateSalary ()
        {   
            decimal hourValue = 50;
            return hourValue * (HoursWorked + ExtraHours);
        }
    }

}