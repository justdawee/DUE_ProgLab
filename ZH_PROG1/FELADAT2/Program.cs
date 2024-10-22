namespace FELADAT2;
public class Program
{
    public List<Customer> customers = new List<Customer>();
    public List<Employee> employees = new List<Employee>();
    public List<Office> offices = new List<Office>();
    public List<Orders> orders = new List<Orders>();

    static void Main(string[] args)
    {
        Program program = new Program();
        program.LoadData();

        // lekérdezések
        var employeeEmails = program.QueryEmployeeEmails();
        var highCreditCustomers = program.QueryHighCreditCustomers();
        var salesManagerOffices = program.QuerySalesManagerOffices();
        var groupedCreditCustomers = program.QueryGroupedCreditCustomers();
        var signalGiftStoresInfo = program.QuerySignalGiftStoresInfo();

        // Eredmények megjelenítése
        Console.WriteLine("Employee Emails:");
        foreach (var email in employeeEmails)
        {
            Console.WriteLine(email);
        }

        Console.WriteLine("\nHigh Credit Customers:");
        foreach (var cust in highCreditCustomers)
        {
            Console.WriteLine(cust);
        }

        Console.WriteLine("\nSales Manager Offices:");
        foreach (var office in salesManagerOffices)
        {
            Console.WriteLine(office);
        }

        Console.WriteLine("\nGrouped Customers by Credit Limit:");
        foreach (var group in groupedCreditCustomers)
        {
            Console.WriteLine($"{group.Key}:");
            foreach (var cust in group)
            {
                Console.WriteLine(cust);
            }
        }

        Console.WriteLine("\nSignal Gift Stores Information:");
        foreach (var info in signalGiftStoresInfo)
        {
            Console.WriteLine(info);
        }
    }

    private void LoadData()
    {
        customers = File.ReadAllLines("customers.csv").Skip(1).Select(Customer.FromCsv).ToList(); //customers.csv betöltése
        employees = File.ReadAllLines("employees.csv").Skip(1).Select(Employee.FromCsv).ToList(); //employees.csv betöltése
        offices = File.ReadAllLines("offices.csv").Skip(1).Select(Office.FromCsv).ToList(); //offices.csv betöltése
        orders = File.ReadAllLines("orders.csv").Skip(1).Select(Orders.FromCsv).ToList(); //orders.csv betöltése
    }

    private IEnumerable<string> QueryEmployeeEmails()
    {
        return employees.Select(e => e.Email); // Query #1
    }

    private IEnumerable<Customer> QueryHighCreditCustomers()
    {
        return customers.Where(c => c.CreditLimit > 150000); // Query #2
    }

    private IEnumerable<Office> QuerySalesManagerOffices()
    {
        var salesManagers = employees.Where(e => e.JobTitle.Contains("Sales Manager"));
        var officeCodes = salesManagers.Select(sm => sm.OfficeCode).Distinct();
        return offices.Where(o => officeCodes.Contains(o.OfficeCode.ToString())); // Query #3
    }

    private IEnumerable<IGrouping<string, Customer>> QueryGroupedCreditCustomers()
    {
        return customers.GroupBy(c => c.CreditLimit > 100000 ? "High Credit Limit" : "Normal Credit Limit"); // Query #4
    }

    private IEnumerable<string> QuerySignalGiftStoresInfo()
    {
        var signalGift = customers.FirstOrDefault(c => c.CustomerName == "Signal Gift Stores");

        if (signalGift == null)
        {
            return new List<string> { "No data found for Signal Gift Stores" }; //ha üres a lista
        }

        var employeeDetails = employees.FirstOrDefault(e => e.EmployeeNumber == signalGift.SalesRepEmployeeNumber);
        var officeDetails = offices.FirstOrDefault(o => o.OfficeCode == int.Parse(employeeDetails.OfficeCode));
        var ordersDetails = orders.Where(o => o.CustomerNumber == signalGift.CustomerNumber).ToList();

        var details = new List<string>();
        details.Add($"Employee Name: {employeeDetails.FirstName} {employeeDetails.LastName}");
        details.Add($"Job Title: {employeeDetails.JobTitle}");
        details.Add($"Email: {employeeDetails.Email}");
        details.Add($"Office Phone: {officeDetails.Phone}");
        foreach (var order in ordersDetails)
        {
            details.Add($"Order Number: {order.OrderNumber}, Order Date: {order.OrderDate}, Shipped Date: {order.ShippedDate}, Status: {order.Status}");
        }

        return details; // Query #5
    }
}
