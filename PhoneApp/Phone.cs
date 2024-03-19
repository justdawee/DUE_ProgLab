namespace Oraimunka;

public class Phone
{
    public required string Model { get; init; }

    public required Phonebook Phonebook { get; init; }

    public void WriteContacts()
    {
        Console.WriteLine($"Model: {Model}");

        foreach (var entry in Phonebook)
        {
            Console.WriteLine(entry.ToString());
        }

        Console.WriteLine();
    }
}