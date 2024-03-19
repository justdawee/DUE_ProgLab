namespace AnimalHospitalApp;

public class Snake : Animal
{
    public string SnakeSound { get; set; }
    public Snake(DateTime arrival, DateTime departure, Owner owner, int? chipId, int? age, Gender gender, string name, string sound) : base(arrival, departure, owner, chipId, age, gender, name, sound)
    {
    }
    public Snake(DateTime arrival, DateTime departure,int? feedPeriod, Owner owner, int? chipId, int? age, Gender gender, string name, string snakeSound) : base(arrival, departure, owner, chipId, age, gender, name, snakeSound)
    {
    }
    
    public int? getFeedPeriod()
    {
        return 0;
    }
    
    public void makeSound()
    {
    }

    public void setFeedPeriod(int period)
    {
        
    }
}