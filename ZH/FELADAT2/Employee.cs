namespace FELADAT2;

public class Employee
{
    public int EmployeeNumber { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Extension { get; set; }
    public string Email { get; set; }
    public string OfficeCode { get; set; }
    public string? ReportsTo { get; set; }
    public string JobTitle { get; set; }

    public static Employee FromCsv(string csvLine)
    {
        string[] values = csvLine.Split(','); 
        //nem tudom hogy látja majd-e valaki ezt, de kb 1 órám azzal ment el hogy azt kerestem mi a baja a kódnak
        //közben csak annyi volt az egész baj hogy a pontosvessző helyett ide a separator nem az mint pl a customer.csv-nél hanem egy sima vessző...
        //értem én hogy figyelni kell, csak az ember arra következtet hogyha kapunk egy előre létrehozott adatfájlt akkor legalább a formázás
        //azonos nem pedig eltérő... végülis a lényeg hogy sikerült rájönni a problémára.
        return new Employee
        {
            EmployeeNumber = int.Parse(values[0]),
            LastName = values[1],
            FirstName = values[2],
            Extension = values[3],
            Email = values[4],
            OfficeCode = values[5],
            ReportsTo = values[6].Equals("NULL") ? null : values[6],
            JobTitle = values[7]
        };
    }

    
}
