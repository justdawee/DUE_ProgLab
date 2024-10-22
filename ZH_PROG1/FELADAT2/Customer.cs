using System.Globalization;

namespace FELADAT2;

public class Customer
{
    public int CustomerNumber { get; set; }
    public string? CustomerName { get; set; }
    public string? ContactLastName { get; set; }
    public string? ContactFirstName { get; set; }
    public string? Phone { get; set; }
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? PostalCode { get; set; }
    public string? Country { get; set; }
    public int? SalesRepEmployeeNumber { get; set; }
    public double CreditLimit { get; set; }

    public static Customer FromCsv(string csvLine)
    {
        string?[] values = csvLine.Split(';');
        Customer customer = new Customer
        {
            CustomerNumber = int.Parse(values[0]),
            CustomerName = values[1].Equals("NULL") ? null : values[1],
            ContactLastName = values[2].Equals("NULL") ? null : values[2],
            ContactFirstName = values[3].Equals("NULL") ? null : values[3].Trim(),
            Phone = values[4].Equals("NULL") ? null : values[4],
            AddressLine1 = values[5].Equals("NULL") ? null : values[5],
            AddressLine2 = values[6].Equals("NULL") ? null : values[6],
            City = values[7].Equals("NULL") ? null : values[7],
            State = values[8].Equals("NULL") ? null : values[8],
            PostalCode = values[9].Equals("NULL") ? null : values[9],
            Country = values[10].Equals("NULL") ? null : values[10],
            SalesRepEmployeeNumber = values[11].Equals("NULL") ? null : int.Parse(values[11]),
            CreditLimit = values[12].Equals("NULL") ? 0.0 : double.Parse(values[12], CultureInfo.InvariantCulture)
        };
        return customer;
    }

    public override string ToString()
    {
        return $"{CustomerName}: {CreditLimit} ({CustomerNumber})";
    }
}
