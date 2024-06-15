// String Compression: Implement a method to perform basic string compression using the counts
// of repeated characters. For example, the string aabcccccaaa would become a2blc5a3, If the
// "compressed" string would not become smaller than the original string, your method should return
// the original string. You can assume the string has only uppercase and lowercase letters (a - z).

using System.Text;

namespace ConsoleApplicationStringCompression;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter string: ");
        string? str = Console.ReadLine();
        Console.Write(GetCompressedString(str));
    }

    static string GetCompressedString(string str)
    {
        Dictionary<char,int> dict= new Dictionary<char, int>();
        for (int i = 0; i < str.Length; i++)
        {
            if(dict.TryGetValue(str[i], out var count)){
                dict[str[i]] = count + 1;
            }
            else{
                dict[str[i]]=1;
            }
        }

        if(dict.Count*2==str.Length)
           return str;

        StringBuilder strb= new StringBuilder();

        foreach(KeyValuePair<char, int> entry in dict)
        {
              strb.Append(entry.Key.ToString()+entry.Value);
        }
        return strb.ToString();
    }
}
