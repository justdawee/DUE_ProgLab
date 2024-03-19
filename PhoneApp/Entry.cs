namespace Oraimunka;

public class Entry
{
    public required string Name { get; init; }

    public required string PhoneNumber { get; init; }

    public string? Email { get; init; }

    public DateTime? DateOfBirth { get; init; }

    public override string ToString()
    {
        return $"{Name,20}\t{PhoneNumber.AsSpan().ConvertPhoneNumberToHungarianFormat(),20}\t{Email ?? "none",20}\t{DateOfBirth?.ToString("d") ?? "none",30}";
    }
}