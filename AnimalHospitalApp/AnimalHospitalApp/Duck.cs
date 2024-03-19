namespace AnimalHospitalApp;

public class Duck : Animal
{
    private int? feedPeriod;
    private int? legsMissing;
    private readonly int numberOfLegs = 4;
    
    public string DuckSound { get; set; }
    public Duck(DateTime arrival, DateTime departure, Owner owner, int? chipId, int? age, Gender gender, string name, string sound) : base(arrival, departure, owner, chipId, age, gender, name, sound)
    {
    }
    public Duck(DateTime arrival, DateTime departure, int? feedPeriod, int? legsMissing, Owner owner, int? chipId, int? age, Gender gender, string name, string duckSound) : base(arrival, departure, owner, chipId, age, gender, name, duckSound)
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