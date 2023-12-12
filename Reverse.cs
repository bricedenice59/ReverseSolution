using System.Text;

namespace Reverse;

public static class ReverseString
{
    public static string ReverseStringOptimized(this string strInput)
    {
        if (string.IsNullOrEmpty(strInput)) return null;

        Span<char> chars = strInput.ToCharArray();
        for (var i = 0; i < strInput.Length; i++)
        {
            chars[strInput.Length - 1 - i] = strInput[i];
        }

        return new string(chars);
    }

    public static string ReverseStringWithStringBuilder(this string strInput)
    {
        if (string.IsNullOrEmpty(strInput)) return null;

        StringBuilder sb = new StringBuilder(strInput.Length);
        int index = strInput.Length;
        while (index != 0)
        {
            sb.Append(strInput[index - 1]);
            index--;
        }

        return sb.ToString();
    }
}