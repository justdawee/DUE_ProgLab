namespace PersonGeneratorApp;

public class Person
{
    public Address address = new Address();
    public List<Car> cars;

    public DateTime Birthday { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public bool HasACar => cars != null && cars.Count > 0;
    public string Mobile { get; set; }
    public string Telephone { get; set; }

}