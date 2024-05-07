namespace FELADAT1;

class Program
{
    static void Main(string[] args)
    {
        string[] content = ReadFile("planets.txt");
        FileDownload fileDownloader = new FileDownload();
        List<Planet> planets = new List<Planet>();

        foreach (var line in content)
        {
            planets.Add(new Planet(line));
        }

        foreach (var planet in planets)
        {
            string localFilePath = Path.Combine(Environment.CurrentDirectory, planet.Name);
            if (File.Exists(localFilePath))
            {
                File.Delete(localFilePath);
            }
            bool success = fileDownloader.StartDownload(planet.Url, localFilePath);
            Console.WriteLine(success ? "Download succeeded for " + planet.Name : "Download failed for " + planet.Name);
        }
    }
    
    static string[] ReadFile(string path)
    {
        return File.ReadAllLines(path);
    }
}