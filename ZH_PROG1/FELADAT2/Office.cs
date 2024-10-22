namespace FELADAT2;

public class Office
{
    public int OfficeCode { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Territory { get; set; }

    public static Office FromCsv(string csvLine)
    {
        string[] values = csvLine.Split(',');
        //nem tudom hogy látja majd-e valaki ezt, de kb 1 órám azzal ment el hogy azt kerestem mi a baja a kódnak
        //közben csak annyi volt az egész baj hogy a pontosvessző helyett ide a separator nem az mint pl a customer.csv-nél hanem egy sima vessző...
        //értem én hogy figyelni kell, csak az ember arra következtet hogyha kapunk egy előre létrehozott adatfájlt akkor legalább a formázás
        //azonos nem pedig eltérő... végülis a lényeg hogy sikerült rájönni a problémára.
        return new Office
        {
            OfficeCode = int.Parse(values[0]),
            City = values[1],
            Phone = values[2],
            AddressLine1 = values[3],
            AddressLine2 = values[4],
            State = values[5],
            PostalCode = values[6],
            Territory = values[7]
        };
    }

    public override string ToString()
    {
        return $"{OfficeCode}: {PostalCode} ({Territory})";
    }
    
    public Office GetOffice(Program program)
    {
        return program.offices.FirstOrDefault(o => o.OfficeCode == this.OfficeCode);
    }
}
