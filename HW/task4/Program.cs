//В прямоугольной матрице найти строку с наименьшей суммой элементов
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
void SumInRows(int[,] matrix, int[] array)
{
for(int i = 0; i< matrix.GetLength(0); i++)
{
    int sum = 0;
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i,j];
    }
    array[i] = sum;
}
}
int ResultOfTask(int[] array)
{
    int any = 0;
    for(int i = 0; i < array.Length; i++)
    {
    int result = array[0];
    if(result > array[i])
    {
        result = array[i];
        any = i;
    }
    }
    return any;
}
Console.WriteLine("How much rows in matrix?");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("How much columns in matrix?");
int columns = int.Parse(Console.ReadLine());
int[,] matrix = new int[rows, columns];
int[] array = new int[rows];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
SumInRows(matrix, array);
Console.Write("Rows is ");
Console.WriteLine(ResultOfTask(array));



