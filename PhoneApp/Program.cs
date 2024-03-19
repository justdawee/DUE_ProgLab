// See https://aka.ms/new-console-template for more information

using Oraimunka;

var phonebook = new Phonebook();

var entries = new List<Entry>
{
    new()
    {
        Name = "Melanie B Montgomery",
        PhoneNumber = "06101234567"
    },
    new()
    {
        Name = "Cheryl D August",
        PhoneNumber = "06119998888",
        Email = "orville_mcke@gmail.com"
    },
    new()
    {
        Name = "Debbie R Delvalle",
        PhoneNumber = "06121211212",
        Email = "chasity2013@hotmail.com",
        DateOfBirth = new DateTime(1983, 10, 24)
    },
    new()
    {
        Name = "Dani R Taylor",
        PhoneNumber = "06135556666",
        Email = "hayden197yahoo.com",
        DateOfBirth = new DateTime(1971, 12, 10)
    },
    new()
    {
        Name = "Debbie R Delvalle",
        PhoneNumber = "06107839527"
    }
};

phonebook.AddEntry(entries);

var samsungGalaxyS10Plus = new Phone
{
    Model = "Samsung Galaxy S10+",
    Phonebook = phonebook
};

samsungGalaxyS10Plus.WriteContacts();

var iphoneXs = new Phone
{
    Model = "iPhone XS",
    Phonebook = phonebook.HardCopy()
};

iphoneXs.WriteContacts();

iphoneXs.Phonebook.AddEntry(new Entry
{
    Name = "William P. Sanchez",
    PhoneNumber = "06102702857"
});

iphoneXs.Phonebook.RemoveEntryByPhoneNumber("06119998888");

samsungGalaxyS10Plus.WriteContacts();

iphoneXs.WriteContacts();

Console.ReadKey();