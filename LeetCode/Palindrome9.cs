public class Palindrome9
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) { return false; }
        if (x < 10) { return true; }

        var temp = x;
        var b = 0;
        var digit = 0;
        while (temp != 0)
        {
            digit = temp % 10;
            b = b * 10 + digit;
            temp /= 10;
        }
        return x == b;
    }
}