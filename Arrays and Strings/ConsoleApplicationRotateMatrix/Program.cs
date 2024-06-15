// Rotate Matrix: Given an image represented by an NxN matrix, where each pixel in the image is 4
// bytes, write a method to rotate the image by 90 degrees.

namespace ConsoleApplicationRotateMatrix;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Matrix Size");
        Console.Write("Rows & Columns : ");
        int rowsCols=Convert.ToInt32(Console.ReadLine());
        var stringArray=CreateMatrix(rowsCols,rowsCols);
        Console.WriteLine("Before Rotation");
        DisplayMatrix(stringArray,rowsCols,rowsCols);
        var newStringArray=RotateMatrix(stringArray,rowsCols,rowsCols);
        Console.WriteLine("After Rotation");
        DisplayMatrix(newStringArray,rowsCols,rowsCols);
    }

    static string[,] CreateMatrix(int rows,int columns){
       string[,] arry= new string[rows,columns];
        for(int r=0;r<rows;r++){
            for(int c=0;c<columns;c++){
                Console.Write("Row {0} Column {1} : ",r,c);
                 arry[r,c]= Console.ReadLine();
            }
        }
        return arry;
    }

    static void DisplayMatrix(string[,] arry,int rows, int columns){
        for(int r=0;r<rows;r++){
            for(int c=0;c<columns;c++){
                Console.Write(arry[r,c]+" ");
            }
            Console.WriteLine();
        } 
    }

    static string[,] RotateMatrix(string[,] arry,int rows, int columns){    
        string[,] newArry= new string[rows,columns];
        for(int r=0;r<rows;r++){
            for(int c=0;c<columns;c++){
                newArry[c,rows-1-r]= arry[r,c];
            }
        } 
        return newArry;
    }
}
