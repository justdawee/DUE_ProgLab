namespace PhoneApp;

public class ConvertPhoneNumberTo
{
    private string countryCode;
    private string firstPart;
    private string providerCode;
    private string secondPart;

    public static string toHungarianFormat(string phoneNumber)
    {
        ConvertPhoneNumberTo convertPhoneNumber = new ConvertPhoneNumberTo();
        convertPhoneNumber.countryCode = "+36";
        convertPhoneNumber.firstPart = phoneNumber.Substring(0, 2);
        convertPhoneNumber.providerCode = phoneNumber.Substring(2, 2);
        convertPhoneNumber.secondPart = phoneNumber.Substring(4, 6);
        return string.Format($"{convertPhoneNumber.countryCode}{convertPhoneNumber.providerCode}/{convertPhoneNumber.firstPart}-{convertPhoneNumber.secondPart}");
    }
}