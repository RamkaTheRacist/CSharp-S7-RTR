//Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
void FillArray(double[,] any)
{
    for(int i = 0; i < any.GetLength(0); i++)
{
    for(int j = 0; j < any.GetLength(1); j++)
    {
        any[i, j] = new Random().Next(0, 10);
    }
}
}
void PrintArray(double[,] any)
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
void ArithmeticMean(double[,] any, double[] array)
{
for(int i = 0; i < any.GetLength(1); i++)
{
    double result = 0;
    for(int j = 0; j < any.GetLength(0); j++)
    {
        result = result + any[j, i];
    }
    array[i] = result / array.Length;
    
}
}
Console.WriteLine("How much rows in matrix?");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("How much columns in matrix?");
int columns = int.Parse(Console.ReadLine());
double[,] matrix = new double[rows, columns];
double[] array = new double[rows];

FillArray(matrix);
PrintArray(matrix);
ArithmeticMean(matrix, array);
for(int i =0;i<array.Length;i++) Console.Write($"{array[i]} ");

