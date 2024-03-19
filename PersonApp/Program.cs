namespace PersonApp;

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        
        person1.SetFirstName("Nagy");
        person1.SetLastName("József");
        person1.SetGender(false);
        person1.SetDateOfBirth(new DateTime(1980, 1, 1));

        Console.WriteLine(person1.GetFullName());
        Console.WriteLine(person1.GetGender());
        Console.WriteLine(person1.GetDateOfBirth());
    }
}