namespace FELADAT1;

public class Planet
{
    public string Name { get; private set; }
    public string Url { get; private set; }

    public Planet(string planetInfo)
    {
        var parts = planetInfo.Split(';');
        Name = parts[0] + ".jpg";  // pl: "xy.jpg"
        Url = parts[1];
    }
}
