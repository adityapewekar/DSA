
// URLify: Write a method to replace all spaces in a string with '%20'. You may assume that the string
// has sufficient space at the end to hold the additional characters, and that you are given the "true"
// length of the string. (Note: If implementing in Java, please use a character array so that you can
// perform this operation in place.)
// EXAMPLE
// Input: "Mr 3ohn Smith 13
// Output: "Mr%203ohn%20Smith"

using System.Text;

namespace ConsoleApplciationURLify;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string: ");
        string? str= Console.ReadLine();
        Console.WriteLine(Program.URLifyString(str,str.Length));
    }

    static string URLifyString(string url, int length){
        char[] urlArry=url.ToCharArray();
        StringBuilder new_str= new StringBuilder();
        for(int i=0;i<length;i++){
            if(urlArry[i]==' ')
            { 
                new_str.Append("%20");
            }
            else{
                new_str.Append(urlArry[i]);
            }
        }
        return new_str.ToString();
    }
}