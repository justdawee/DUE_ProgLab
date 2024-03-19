namespace PhoneApp_shitty;

public class Entry
{
    public string Name { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Email { get; private set; }
    public DateTime? DateOfBirth { get; set; }

    public Entry(string name, string phoneNumber)
    {
        Name = name;
        PhoneNumber = phoneNumber;
    }

    public Entry(string name, string phoneNumber, string email)
        : this(name, phoneNumber)
    {
        Email = email;
    }

    public Entry(string name, string phoneNumber, DateTime? dateOfBirth)
        : this(name, phoneNumber)
    {
        DateOfBirth = dateOfBirth;
    }

    public Entry(string name, string phoneNumber, string email, DateTime?
        dateOfBirth)
        : this(name, phoneNumber, email)
    {
        DateOfBirth = dateOfBirth;
    }
}