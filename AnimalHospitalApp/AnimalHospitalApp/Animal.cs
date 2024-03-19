namespace AnimalHospitalApp;

public enum Gender
{
    Female,
    Male,
    Unknown
};

public class Animal
{
    private int? age;
    private string name;
    protected string NN = "No Name";
    protected string NS = "No Sound";
    private string sound;

    public DateTime ArrivalDate { get; set; }
    public int? ChipId { get; set; }
    public DateTime DepartureTime { get; set; }
    public Gender Gender { get; set; }
    public Owner Owner { get; set; }

    public int? Age
    {
        get => age;
        set => age = value;
    }
    public string Name
    {
        get => name;
        set => name = value;
    }
    public string Sound
    {
        get => sound;
        set => sound = value;
    }
    
    public Animal(DateTime arrival, DateTime departure, Owner owner, int? chipId, int? age, Gender gender, string name, string sound)
    {
        ArrivalDate = arrival;
        DepartureTime = departure;
        Owner = owner;
        ChipId = chipId;
        this.age = age;
        Gender = gender;
        this.name = name;
        this.sound = sound;
    }
    
    public virtual void makeSound()
    {
        Console.WriteLine($"{Name} says {Sound}");
    }
}

public class AnimalHealth
{
    public bool isHealthyWeight(double height, double weight)
    {
        double ratio = weight / height;
        return ratio >= 0.18 && ratio <= 0.27;
    }
}