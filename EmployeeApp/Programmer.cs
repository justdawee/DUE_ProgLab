namespace EmployeeApp;

public class Programmer : FullTimeEmployee, IProgrammer
{
    public string WorkPlace { get; set; }
    protected Programmer(
        int employeeId,
        string firstName, 
        string lastName, 
        string email, 
        string phone, 
        Gender gender, 
        Address address,
        double annualSalary,
        string workplace) 
        : base(employeeId, firstName, lastName, email, phone, gender, address, annualSalary)
    {
        WorkPlace = workplace;
    }
    public override string getJobName()
    {
        return "Programmer";
    }
    public void doProgramming()
    {
        Console.WriteLine("I am programming.");
    }
}