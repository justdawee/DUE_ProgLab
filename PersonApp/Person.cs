namespace PersonApp;

public class Person
{
    private DateTime _dateOfBirth;
    private string _firstName;
    private string _lastName;
    private bool _isFemale;

    public DateTime GetDateOfBirth() => _dateOfBirth;

    public string GetFullName() => $"{_firstName} {_lastName}";

    public string GetGender()
    {
        return _isFemale ? "Female" : "Male";
    }
    public void SetDateOfBirth(DateTime dob) => _dateOfBirth = dob;

    public void SetFirstName(string fName) => _firstName = fName;

    public void SetLastName(string lName) => _lastName = lName;

    public void SetGender(bool fGender) => _isFemale = fGender;
}