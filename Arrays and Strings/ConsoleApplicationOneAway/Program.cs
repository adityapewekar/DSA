// One Away: There are three types of edits that can be performed on strings: insert a character,
// remove a character, or replace a character. Given two strings, write a function to check if they are
// one edit (or zero edits) away.
// EXAMPLE
// p a l e , pie -> false
// p a l e s , pale -> true
// p a l e , bale -> true
// p a l e , bake -> false

namespace ConsoleApplicationOneAway;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter First String: ");
        string? str1 = Console.ReadLine();
        Console.Write("Enter Second String: ");
        string? str2 = Console.ReadLine();
        Console.WriteLine(IsOneAway(str1, str2));
    }

    static bool IsOneAway(string str1, string str2)
    {
        int m = str1.Length;
        int n = str2.Length;

        if (Math.Abs(m - n) > 1)
            return false;

        int diffCount = 0;
        int i = 0, j = 0;
        while (i < m && j < n)
        {
            if (str1[i] != str2[j])
            {
                diffCount++;

                if (diffCount == 2)
                    return false;
            }
            if (i <= m - 1)
                i++;
            if (j <= n - 1)
                j++;
        }
        // If last character is extra 
        // in any string
        if (i < m || j < n)
            diffCount++;

        return diffCount == 1;

    }
}
