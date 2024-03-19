namespace PersonGeneratorApp;

public class Generator
{
    private Random rnd = new Random();
    private string[] firstNamesFemale = { "Alexandra", "Alison", "Maria", "Sophie", "Wanda" };
    private string[] firstNamesMale = { "Brandon", "David", "Gordon", "Jonathan", "Peter" };
    private string[] lastNames = { "Abraham", "Campbell", "Ellison", "Henderson", "Johnston" };
    private string[] streets = { "2708 Adonais Way", "4154 Cherry Tree Drive", "3466 Wilmar Farm Road", "1949 Jadewood Drive", "501 Blane Street" };
    private string[] cities = { "Atlanta", "Jacksonville", "Lanham", "Wheatfield", "Fairview Heights" };
    private string[] states = { "Georgia(GA)", "Florida(FL)", "Maryland(MD)", "Indiana(IN)", "Missouri(MO)," };
    private string[] models = { "Volvo", "BMW", "Jaguar", "Audi", "Ford" };
    private string generateFirstNamesFemale()
    {
        return firstNamesFemale[rnd.Next(firstNamesFemale.Length)];
    }
    private string generateFirstNamesMale()
    {
        return firstNamesMale[rnd.Next(firstNamesMale.Length)];
    }
    private string generateLastNames()
    {
        return lastNames[rnd.Next(lastNames.Length)];
    }
    private string generateStreets()
    {
        return streets[rnd.Next(streets.Length)];
    }
    private string generateCities()
    {
        return cities[rnd.Next(cities.Length)];
    }
    private string generateStates()
    {
        return states[rnd.Next(states.Length)];
    }
    private int generateZips()
    {
        return rnd.Next(1, 9999);
    }
    private string generateGender()
    {
        bool isFemale = rnd.Next(100) < 50 ? true : false;
        return isFemale ? "Female" : "Male";
    }
    private DateTime generateBirthDay()
    {
        DateTime start = new DateTime(1900, 1, 1);
        int range = (DateTime.Today - start).Days;
        return start.AddDays(rnd.Next(range)).AddHours(rnd.Next(0,
            24)).AddMinutes(rnd.Next(0, 60)).AddSeconds(rnd.Next(0, 60));
    }
    private string generateTelephones()
    {
        return string.Format(rnd.Next(100, 999) + "-" + rnd.Next(100, 999) + "-" +
                             rnd.Next(1000, 9999));
    }
    private string generateMobiles()
    {
        return string.Format(rnd.Next(100, 999) + "-" + rnd.Next(100, 999) + "-" +
                             rnd.Next(1000, 9999));
    }
    private bool generateHasACar()
    {
        return rnd.Next(100) < 50 ? true : false;
    }
    private string generateModel()
    {
        return models[rnd.Next(models.Length)];
    }
    private int generateHorsePowers()
    {
        return rnd.Next(115, 300);
    }
    private int generateMaximumSpeed()
    {
        return rnd.Next(180, 300);
    }

    public Person generatePerson(Person person)
    {
        person.Gender = generateGender();
        if (person.Gender.Equals("Female"))
            person.FirstName = generateFirstNamesFemale();
        else
            person.FirstName = generateFirstNamesMale();
        person.LastName = generateLastNames();
        person.Birthday = generateBirthDay();
        person.Telephone = generateTelephones();
        person.Mobile = generateMobiles();
        person.address.Street = generateStreets();
        person.address.City = generateCities();
        person.address.State = generateStates();
        person.address.Zip = generateZips();
        if (person.HasACar.Equals(true))
        {
            person.cars = new List<Car>();
            int howMany = rnd.Next(1, 5);
            for (int i = 0; i < howMany; i++)
            {
                person.cars.Add(new Car(generateHorsePowers(), generateMaximumSpeed(), generateModel()));
            }
        }

        return person;
    }
}