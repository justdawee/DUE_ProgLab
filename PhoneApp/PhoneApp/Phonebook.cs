using System.Collections;
using System.Runtime.InteropServices.ComTypes;

namespace PhoneApp;

public class Phonebook
{
    private List<Entry> contacts;

    public void addEntry(string name, string phoneNumber, string? email, DateTime? dateOfBirth)
    {
        bool isEmailNull = (email == null) ? true : false;
        bool isdateOfBirthNull = (dateOfBirth == null) ? true : false;

        if (isEmailNull && isdateOfBirthNull)
        {
            contacts.Add(new Entry(name, ConvertPhoneNumberTo.toHungarianFormat(phoneNumber)));
        }
        else if (isEmailNull)
        {
            contacts.Add(new Entry(name, ConvertPhoneNumberTo.toHungarianFormat(phoneNumber), email));
        }
        else if (isdateOfBirthNull)
        {
            contacts.Add(new Entry(name, ConvertPhoneNumberTo.toHungarianFormat(phoneNumber), dateOfBirth.Value));
        }
    }
    public IEnumerator<Entry> GetEnumerator()
    {
        foreach (Entry oneEntry in contacts)
        {
            yield return oneEntry;
        }
    }
    public Phonebook()
    {
        contacts = new List<Entry>();
    }
    public Phonebook(Phonebook phonebook)
    {
        contacts = phonebook.contacts;
    }

    public void removeEntry(string phoneNumber)
    {
        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].PhoneNumber == ConvertPhoneNumberTo.toHungarianFormat(phoneNumber))
            {
                contacts.RemoveAt(i);
                return;
            }
        }
    }
}