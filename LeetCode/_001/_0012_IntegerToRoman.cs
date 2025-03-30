using System.Text;

namespace LeetCode._001;

public class _0012_IntegerToRoman
{
    public string IntToRoman(int num)
    {
        StringBuilder stringBuilder = new();

        foreach (var romanNumeral in RomanNumerals)
        {
            while (num >= romanNumeral.Value)
            {
                stringBuilder.Append(romanNumeral.Symbol);
                num -= romanNumeral.Value;
            }
        }
        return stringBuilder.ToString();
    }

    private record RomanNumeral(int Value, string Symbol);

    private static readonly RomanNumeral[] RomanNumerals =
    [
        new(1000, "M"),
        new(900, "CM"),
        new(500, "D"),
        new(400, "CD"),
        new(100, "C"),
        new(90, "XC"),
        new(50, "L"),
        new(40, "XL"),
        new(10, "X"),
        new(9, "IX"),
        new(5, "V"),
        new(4, "IV"),
        new(1, "I"),
    ];
}
