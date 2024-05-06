using OpenClose;

CalculateSalaryMonthly(new List<object>() {
    new EmployeeFullTime("Pepito Pérez", 160, 30000M),
    new EmployeePartTime("Manuel Lopera", 180, 20000M),
    new EmployeeContractor("José Molina", 120, 10000M)
});


void CalculateSalaryMonthly(List<object> employees) 
{
    foreach (var employee in employees)
    {
        if (employee is EmployeeFullTime) 
        {
            EmployeeFullTime employeeFullTime = (EmployeeFullTime)employee;
            decimal salary = employeeFullTime.GetSalary();
            Console.WriteLine($"Empleado: {employeeFullTime.Fullname}, Pago: {salary:C1} ");
        }
        else if (employee is EmployeePartTime)
        {
            EmployeePartTime employeePartTime = (EmployeePartTime)employee;
            decimal salary = employeePartTime.GetSalary();
            Console.WriteLine($"Empleado: {employeePartTime.Fullname}, Pago: {salary:C1} ");
        }
        else 
        {
            EmployeeContractor employeeContractor = (EmployeeContractor)employee;
            decimal salary = employeeContractor.GetSalary();
            Console.WriteLine($"Empleado: {employeeContractor.Fullname}, Pago: {salary:C1} ");
        }
    }

}