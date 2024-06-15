// Palindrome Permutation: Given a string, write a function to check if it is a permutation of a palindrome.
// A palindrome is a word or phrase that is the same forwards and backwards. A permutation
// is a rearrangement of letters. The palindrome does not need to be limited to just dictionary words.
// EXAMPLE
// Input: Tact Coa
// Output: True (permutations: "taco cat", "atco e t a " , etc.)

namespace ConsoleApplicationPalindromePermutation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the string");
        string? str= Console.ReadLine();
        Console.WriteLine(IsPalindromePermutation(str));
    }

public static bool IsPalindromePermutation(string input)
{
    input = input.Replace(" ", "").ToLower();  // Remove spaces and convert to lower case
    Dictionary<char, int> charCounts = new Dictionary<char, int>();  // Dictionary to hold character counts

    // Count the occurrences of each character
    foreach (char c in input)
    {
        if (charCounts.ContainsKey(c))
            charCounts[c]++;
        else
            charCounts[c] = 1;
    }

    // Check that no more than one character has an odd count
    bool foundOdd = false;
    foreach (KeyValuePair<char, int> pair in charCounts)
    {
        if (pair.Value % 2 == 1)
        {
            if (foundOdd)
                return false;  // More than one char with odd count
            foundOdd = true;
        } 
    }

    // If we got this far, it's a palindrome permutation
    return true;
}

}
