using System;

namespace ConsoleApplciationString2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter First String");
        char[] str1= Console.ReadLine()?.ToCharArray();
        Console.WriteLine("Enter Second String");
        char[] str2=Console.ReadLine()?.ToCharArray();
        if(isPermutation(str1,str2))
        {
            Console.WriteLine("Is Permutable");
        }
        else
        {
            Console.WriteLine("Is not Permutable");
        }
    }

    static bool isPermutation(char[] str1,char[] str2){
        Array.Sort(str1);
        Array.Sort(str2);
        for (int i = 0; i < str1.Count(); i++) 
        if (str1[i] != str2[i]) 
            return false;
        return true;
    }
}
