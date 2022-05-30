//В матрице чисел найти сумму элементов главной диагонали
void FillArray(int[,] any)
{
    for(int i = 0; i < any.GetLength(0); i++)
{
    for(int j = 0; j < any.GetLength(1); j++)
    {
        any[i, j] = new Random().Next(0, 10);
    }
}
}
void PrintArray(int[,] any)
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
int SearchSum(int[,] any)
{
int result = 0;
for(int i = 0; i < any.GetLength(0); i++)
{
    for(int j = 0; j < any.GetLength(1); j++)
    {
        if(j == i)  result = result + any[i, j];
    }
    
}
return result;
}
Console.WriteLine("Which size of square matrix?");
int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];
FillArray(matrix);
PrintArray(matrix);
int result = SearchSum(matrix);
Console.WriteLine(result);
