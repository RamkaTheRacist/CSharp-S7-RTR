//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
void FillMatrix(int[,] any)
{
    for(int i = 0; i < any.GetLength(0); i++)
{
    for(int j = 0; j < any.GetLength(1); j++)
    {
        any[i, j] = new Random().Next(0, 10);
    }
}
}
void PrintMatrix(int[,] any)
{
for(int i = 0; i < any.GetLength(0); i++) 
{
    for(int j = 0; j < any.GetLength(1); j++)
    {
        Console.Write($"{any[i, j]} ");
    }
Console.WriteLine();
}
}
void SwitchMatrixElements(int[,] any)
{
for(int i = 0; i< any.GetLength(0); i++)
{
    for(int j = 0; j < any.GetLength(1); j++)
    {
        for(int k = j; k < any.GetLength(1); k++)
        {
            if(any[i, k] > any[i, j])
            {
            int tmp = any[i, j];
            any[i, j] = any[i, k];
            any[i, k] = tmp;
            }

        }
    }
    
}
}
Console.WriteLine("How much rows in matrix?");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("How much columns in matrix?");
int columns = int.Parse(Console.ReadLine());
int[,] matrix = new int[rows, columns];
FillMatrix(matrix);
Console.WriteLine("Was:");
PrintMatrix(matrix);
SwitchMatrixElements(matrix);
Console.WriteLine();
Console.WriteLine("Is:");
PrintMatrix(matrix);