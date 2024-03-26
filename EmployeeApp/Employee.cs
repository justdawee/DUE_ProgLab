namespace EmployeeApp;

public enum Gender { Female = 0, Male = 1 }

public abstract class Employee : IFullName
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public Address Address { get; set; }
    public Gender Gender { get; set; }
    public Employee(int employeeId, string firstName, string lastName, string email, string phone, Gender gender, Address address)
    {
        EmployeeId = employeeId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Gender = gender;
        Address = address;
    }

    public string getFullName() => $"{FirstName}+{LastName}";

    public string getBasicInformation()
    {
        return $"Employee ID : {EmployeeId} Name: {getFullName()} Email: {Email}" +
               $"{Address.State}" +
               $"{Address.Street}" +
               $"{Address.Zip}";
    }
    
    public abstract string getJobName();
    public abstract double getMonthlySalary();
}