using System.Collections;

namespace Oraimunka;

public class Phonebook : IEnumerable<Entry>
{
    private readonly IList<Entry> _contacts = new List<Entry>();

    public void AddEntry(IList<Entry> entries)
    {
        foreach (var entry in entries)
        {
            _contacts.Add(entry);

            Console.WriteLine($"New entry has been added: {entry}");
        }

        Console.WriteLine();
    }

    public void AddEntry(params Entry[] entries)
    {
        AddEntry(entries.ToList());
    }

    public void RemoveEntry(params Entry[] entries)
    {
        foreach (var entry in entries)
        {
            _contacts.Remove(entry);
            Console.WriteLine($"Entry has been removed: {entry}");
        }

        Console.WriteLine();
    }

    public void RemoveEntryByPhoneNumber(string phoneNumber)
    {
        foreach (var t in _contacts)
        {
            if (t.PhoneNumber == phoneNumber)
            {
                RemoveEntry(t);
                return;
            }
        }
    }

    public IEnumerator<Entry> GetEnumerator()
    {
        return _contacts.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public Phonebook HardCopy()
    {
        var temp = new List<Entry>(_contacts.Count);

        temp.AddRange(_contacts
            .Select(contract => new Entry
            {
                Name = contract.Name,
                PhoneNumber = contract.PhoneNumber,
                Email = contract.Email,
                DateOfBirth = contract.DateOfBirth
            }));

        var phoneBook = new Phonebook();

        phoneBook.AddEntry(temp);

        return phoneBook;
    }
}