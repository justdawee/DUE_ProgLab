namespace PhoneApp;

public class Entry
{
    public DateTime? DateOfBirth { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public Entry(string name, string phoneNumber, string email, DateTime? dateOfBirth)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
        DateOfBirth = dateOfBirth;
    }
}