namespace PersonGeneratorApp;

public class Car
{
    private int _horsePower;
    private int _maximalSpeed;
    private string _model;
    
    public Car(int horsePower, int maximalSpeed, string model)
    {
        _horsePower = horsePower;
        _maximalSpeed = maximalSpeed;
        _model = model;
    }

    public int getHorsePower() => _horsePower;
    public int getMaximumSpeed() => _maximalSpeed;
    public string getModel() => _model;
}