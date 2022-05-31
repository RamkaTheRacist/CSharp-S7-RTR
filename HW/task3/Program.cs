//Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
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
void SwitchRowsToColumns(int[,]any)
{
for(int i = 0; i < any.GetLength(0); i++)
{
for(int j = i; j < any.GetLength(1); j++)
{
    int tmp = any[i, j];
    any[i,j] = any[j,i];
    any[j,i] = tmp;
}
}
}

Console.WriteLine("How much rows in matrix?");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("How much columns in matrix?");
int columns = int.Parse(Console.ReadLine());
if(rows == columns)
{
int[,] matrix = new int[rows, columns];
FillMatrix(matrix);
Console.WriteLine("Was:");
PrintMatrix(matrix);
Console.WriteLine();
SwitchRowsToColumns(matrix);
Console.WriteLine("Is:");
PrintMatrix(matrix);
}
else Console.WriteLine("Wrong input data: Expecting square matrix");

