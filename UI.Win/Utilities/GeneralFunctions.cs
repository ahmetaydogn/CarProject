using Business.Abstract;

namespace UI.Win.Utilities;

public static class GeneralFunctions
{
    private static readonly Random getRandom = new Random();

    public static string GetRandomBillNumber(IBillService billService)
    {
        var allIDs = billService.GetBillIDs().Data;
        var newBillID = "";
        while (true)
        {
            newBillID = getRandom.Next(100000, 999999).ToString();
            if (allIDs.Contains(newBillID))
                continue;
            else
                break;
        }
        return  newBillID.ToString();
    }
    public static string Strip(this string s, char character)
    {
        s = s.Replace(character.ToString(), "");

        return s;
    }
}
