namespace AnimalHospitalApp;

class Program
{
    static void Main(string[] args)
    {
        /*Random rnd = new Random();
        Owner maxine = new Owner
        {
            Id = -001,
            FirstName = "Maxine",
            LastName = "McEwen"
        };

        Animal woofeors = new Animal(new DateTime(2017, 01, 05), new DateTime(2017, 02, 01), maxine, 001)
        {
            Name = "Woofeors",
            Age = 5,
            Sound = "Growl!"
        };

        Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

        Owner james = new Owner()
        {
            Id = -002,
            FirstName = "James",
            LastName = "Campbell"
        };
        Animal[] dogs = new Dog[2];
        dogs[0] = new Dog(new DateTime(2018, 05, 30), new DateTime(2018, 06, 14), 2, 0, james, "Carilo", 002, 5,
            Gender.Male, "Barking");
        Owner jones = new Owner()
        {
            Id = -003,
            FirstName = "Jones",
            LastName = "Brenda"
        };
        dogs[1] = new Dog(new DateTime(2016, 03, 10), new DateTime(2016, 04, 02), 2, 1, jones, "Derilla", 003, 6,
            Gender.Female, "Grrrr!");
        Owner ellis = new Owner()
        {
            Id = -004,
            FirstName = "Ellis",
            LastName = "Craig"
        };
        Owner noName = new Owner()
        {
            Id = 000,
            FirstName = "No",
            LastName = "Name"
        };
        Cat[] cats = new Cat[2];
        cats[0] = new Cat(new DateTime(2018, 07, 30), new DateTime(2018, 08, 14), 2, 0, noName);
        cats[1] = new Cat(new DateTime(2018, 09, 09), new DateTime(2018, 09, 21), 1, 1, ellis, "Salida", 004, 2, Gender.Female);
        Console.WriteLine("ANIMAL");
        woofeors.makeSound();
        Console.WriteLine("DOGS");
        foreach (Animal dog in dogs)
        {
            dog.makeSound();
            //if(dog is Animal) dog.makeSound();
            //if(dog is Dog) dog.makeSound();
            Console.WriteLine("CATS");
        }

        foreach (Animal cat in cats)
        {
            cat.makeSound();
        }

        Console.WriteLine();
        const string defaultTitleFormat = "{0,25} {1,15} {2,15} {3,10} {4,5} {5,10} {6,10}",
        extendedTitleFormat = defaultTitleFormat + "{7,10} {8,10}";
        Console.WriteLine(string.Format(extendedTitleFormat, "Owner", "Arrival", "Departure", "Name", "Age", "Gender", "Healthy?", "Legs", "Feeds"));
        Console.WriteLine(string.Format(defaultTitleFormat, 
            woofeors.Owner.FirstName + " " + 
            woofeors.Owner.LastName,
            woofeors.ArrivalDate.ToString("yyyy/MM/dd"), 
            woofeors.DepartureDate.ToString("yyyy/MM/dd"), 
            woofeors.Name,
            woofeors.Age, woofeors.Gender, getHealth.isHealthyWeight(60.3, 15.2)));
        foreach (Dog dog in dogs)
        {
            Console.WriteLine(string.Format(extendedTitleFormat,
                dog.Owner.FirstName + " " + dog.Owner.LastName,
                dog.ArrivalDate.ToString("yyyy/MM/dd"),
                dog.DepartureDate.ToString("yyyy/MM/dd"), dog.Name, dog.Age,
                dog.Gender, getHealth.isHealthyWeight(rnd.NextDouble() * 100, rnd.NextDouble() * 100),
                dog.getNumberOfLegs(), dog.getFeedPeriod()));
        }

        foreach (Cat cat in cats)
        {
            Console.WriteLine(string.Format(extendedTitleFormat,
                cat.Owner.FirstName + " " + cat.Owner.LastName,
                cat.ArrivalDate.ToString("yyyy/MM/dd"),
                cat.DepartureDate.ToString("yyyy/MM/dd"), cat.Name, cat.Age,
                cat.Gender, getHealth.isHealthyWeight(rnd.NextDouble() * 100, rnd.NextDouble() * 100),
                cat.getNumberOfLegs(), cat.getFeedPeriod()));
        }
        */
    }
}