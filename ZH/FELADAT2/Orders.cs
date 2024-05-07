namespace FELADAT2;

public class Orders
{
    public int OrderNumber { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime RequiredDate { get; set; }
    public DateTime? ShippedDate { get; set; }
    public string Status { get; set; }
    public string Comments { get; set; }
    public int CustomerNumber { get; set; }

    public static Orders FromCsv(string csvLine)
    {
        string[] values = csvLine.Split(';');
        return new Orders
        {
            OrderNumber = int.Parse(values[0]),
            OrderDate = DateTime.Parse(values[1]),
            RequiredDate = DateTime.Parse(values[2]),
            ShippedDate = values[3].Equals("NULL") ? null : DateTime.Parse(values[3]),
            Status = values[4],
            Comments = values[5],
            CustomerNumber = int.Parse(values[6])
        };
    }
}
