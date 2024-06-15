namespace ConsoleApplciationString1;

// Is Unique: Implement an algorithm to determine if a string has all unique characters. What if you
// cannot use additional data structures?
class Program
{
    public static void Main()
    {
        string input = "GeeksforGeeks";

        if (uniqueCharacters1(input) == true)
            Console.WriteLine("The String " + input
                              + " has all unique characters");
        else
            Console.WriteLine("The String " + input
                              + " has duplicate characters");
    }

    static bool uniqueCharacters1(String str)
    {

        // If at any time we encounter 2
        // same characters, return false
        for (int i = 0; i < str.Length; i++)
            for (int j = i + 1; j < str.Length; j++)
                if (str[i] == str[j])
                    return false;

        // If no duplicate characters
        // encountered, return true
        return true;
    }

    static bool uniqueCharacters2(String str)
    {
        char[] chArray = str.ToCharArray();

        // Using sorting
        Array.Sort(chArray);

        for (int i = 0; i < chArray.Length - 1; i++)
        {

            // if the adjacent elements are not
            // equal, move to next element
            if (chArray[i] != chArray[i + 1])
                continue;

            // if at any time, 2 adjacent elements
            // become equal, return false
            else
                return false;
        }

        return true;
    }
}
