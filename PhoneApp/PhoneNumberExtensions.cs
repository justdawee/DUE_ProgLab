namespace Oraimunka;

public static class PhoneNumberExtensions
{
    public static string ConvertPhoneNumberToHungarianFormat(this ReadOnlySpan<char> phoneNumber)
    {
        var countryCode = phoneNumber.Slice(0, 2);
        var providerCode = phoneNumber.Slice(2, 2);
        var firstPart = phoneNumber.Slice(4, 3);
        var secondPart = phoneNumber.Slice(7, 4);

        var count = countryCode.Length + providerCode.Length + 1 + firstPart.Length + 1 + secondPart.Length;

        Span<char> temp = stackalloc char[count];

        countryCode.CopyTo(temp.Slice(0, 2));

        providerCode.CopyTo(temp.Slice(2, 2));

        temp[4] = '/';

        firstPart.CopyTo(temp.Slice(5, 3));

        temp[8] = '-';

        secondPart.CopyTo(temp.Slice(9, 4));

        return new string(temp.Slice(0, 13));
    }
}