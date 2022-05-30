//Написать программу, которая обменивает элементы первой строки и последней строки
void FillMatrix(double[,] any)
{
    for(int i = 0; i < any.GetLength(0); i++)
{
    for(int j = 0; j < any.GetLength(1); j++)
    {
        any[i, j] = new Random().Next(0, 10);
    }
}
}
void PrintMatrix(double[,] any)
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
void SwitchMatrixElements(double[,] any)
{

    for(int j = 0; j < any.GetLength(1); j++)
    {
        double tmp = any[0, j];
        any[0, j] = any[(any.GetLength(0) - 1), j];
        any[(any.GetLength(0) - 1), j] = tmp;
    }
    
}
Console.WriteLine("How much rows in matrix?");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("How much columns in matrix?");
int columns = int.Parse(Console.ReadLine());
double[,] matrix = new double[rows, columns];

FillMatrix(matrix);
Console.WriteLine("Was:");
PrintMatrix(matrix);
SwitchMatrixElements(matrix);

Console.WriteLine();
Console.WriteLine("Is:");
PrintMatrix(matrix);

