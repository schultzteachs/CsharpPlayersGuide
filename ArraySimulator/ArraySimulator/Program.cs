Console.WriteLine("How many rows?");
int row = Int32.Parse(Console.ReadLine());
Console.WriteLine("How many columns?");
int column = Int32.Parse(Console.ReadLine());

int[,] matrix = new int[row, column];

for (int  i = 0;  i < (matrix.Length);  i++)
{
    for (int b = 0; b < matrix.GetLength(1); b++)
    {
        Console.Write(matrix[i,b] + " ");
    }
    
    Console.WriteLine();
}











































string shower = "shultz";
Console.WriteLine(shower);