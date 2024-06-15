// String Rotation; Assume you have a method i s S u b s t r i n g which checks if one word is a substring
// of another. Given two strings, si and s2, write code to check if s2 is a rotation of si using only one
// call to i s S u b s t r i n g [e.g., "water b o t t l e " is a rotation o P ' e r b o t t l e w a t " ) ,

namespace ConsoleApplicationStringRotation;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first string : ");
        string? s1=Console.ReadLine();
        Console.Write("Enter second string : ");
        string? s2=Console.ReadLine();
        Console.Write("Second string is{0}a rotation of First string",IsSubString(s1,s2)?" ":" not ");
    }


    static bool IsSubString(string s1,string s2){

        if(s1.Length!=s2.Length)
            return false;

        for(int i=0;i<s1.Length;i++){
                if(s1[i]!=s2[s1.Length-i-1])
                    return false;
           }

        return true;
    }
}
