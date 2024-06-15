// Zero Matrix: Write an algorithm such that if an element in an MxN matrix is 0, its entire row and
// column are set to 0.

namespace ConsoleApplicationZeroMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Matrix Size");
            Console.Write("Rows : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");
            int cols = Convert.ToInt32(Console.ReadLine());
            var matrix = CreateMatrix(rows, cols);
            Console.WriteLine("Before ");
            DisplayMatrix(matrix, rows, cols);
            SetZeros(matrix, rows, cols);
            Console.WriteLine("After ");
            DisplayMatrix(matrix, rows, cols);
        }

        static string[,] CreateMatrix(int rows, int columns)
        {
            string[,] matrix = new string[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Console.Write("Row {0} Column {1} : ", r, c);
                    matrix[r, c] = Console.ReadLine();
                }
            }
            return matrix;
        }

        static void DisplayMatrix(string[,] matrix, int rows, int columns)
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Console.Write(matrix[r, c] + " ");
                }
                Console.WriteLine();
            }
        }

        static void SetZeros(string[,] matrix, int rows, int columns)
        {
            bool[] row = new bool[rows];
            bool[] column = new bool[columns];

            // Store the row and column index with value 0
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (matrix[r, c] == "0")
                    {
                        row[r] = true;
                        column[c] = true;
                    }
                }
            }

            // Nullify rows
            for (int r = 0; r < rows; r++)
            {
                if (row[r])
                {
                    NullifyRow(matrix, r, columns);
                }
            }

            // Nullify columns
            for (int c = 0; c < columns; c++)
            {
                if (column[c])
                {
                    NullifyColumn(matrix, c, rows);
                }
            }
        }

        static void NullifyRow(string[,] matrix, int row, int columns)
        {
            for (int c = 0; c < columns; c++)
            {
                matrix[row, c] = "0";
            }
        }

        static void NullifyColumn(string[,] matrix, int col, int rows)
        {
            for (int r = 0; r < rows; r++)
            {
                matrix[r, col] = "0";
            }
        }
    }
}