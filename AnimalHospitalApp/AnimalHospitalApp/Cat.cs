namespace AnimalHospitalApp;

public class Cat : Animal
{
    private int? feedPeriod;
    private int? legsMissing;
    private readonly int numberOfLegs = 4;

    public string CatSound { get; set; }
    public Cat(DateTime arrival, DateTime departure, Owner owner, int? chipId, int? age, Gender gender, string name, string sound) : base(arrival, departure, owner, chipId, age, gender, name, sound)
    {
    }
    public Cat(DateTime arrival, DateTime departure, int? feedPeriod, int? legsMissing, Owner owner, int? chipId, int? age, Gender gender, string name, string catSound) : base(arrival, departure, owner, chipId, age, gender, name, catSound)
    {
    }
    
    public int? getFeedPeriod()
    {
        return feedPeriod;
    }
    
    public int? getNumberOfLegs()
    {
        return numberOfLegs;
    }
    
    public void makeSound()
    {
    }

    public void setFeedPeriod(int? period)
    {
    }

    public void setNumberOfLegs(int? legs)
    {
    }
    
}