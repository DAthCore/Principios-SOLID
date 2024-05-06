namespace Liskov
{
    public abstract class Employee : IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public  Employee(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }  

        public virtual decimal CalculateSalary ()
        {   
            decimal hourValue = 40;
            return hourValue * (HoursWorked);
        } 
    }
}