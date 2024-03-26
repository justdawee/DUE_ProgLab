namespace EmployeeApp;

public abstract class ContractEmployee : Employee
{
    public double HourlyPrice { get; set; }
    public double TotalHours { get; set; }
    protected ContractEmployee(
        int employeeId,
        string firstName, 
        string lastName, 
        string email, 
        string phone, 
        Gender gender, 
        Address address,
        double hourlyPrice,
        double totalHours) 
        : base(employeeId, firstName, lastName, email, phone, gender, address)
    {
        HourlyPrice = hourlyPrice;
        TotalHours = totalHours;
    }
    public override double getMonthlySalary()
    {
        return HourlyPrice * TotalHours;
    }
}