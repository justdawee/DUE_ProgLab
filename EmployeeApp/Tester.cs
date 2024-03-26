namespace EmployeeApp;

public class Tester : ContractEmployee, ITester
{
    public string WorkPlace { get; set; }
    
    protected Tester(
        int employeeId,
        string firstName, 
        string lastName, 
        string email, 
        string phone, 
        Gender gender, 
        Address address,
        double hourlyPrice,
        double totalHours,
        string workplace) 
        : base(employeeId, firstName, lastName, email, phone, gender, address, hourlyPrice, totalHours)
    {
        WorkPlace = workplace;
    }
    public override string getJobName()
    {
        return "Tester";
    }
    public void doTesting()
    {
        Console.WriteLine("I am testing.");
    }
    
}