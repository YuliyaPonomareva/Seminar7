/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9   */

Console.Clear();
int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");
double [,] array = GetArray(rows, columns, -1000, 1001);
PrintArray(array);

int Prompt (string messange)
{
    Console.Write(messange);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

double [,] GetArray (int m, int n, int minValue, int maxValue)
{
    double [,] result = new double [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = Math.Round(new Random().Next(minValue,maxValue)/100.00, 1);
        }
    }
    return result;
}
 
 void PrintArray (double [,] arr)
 {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
 }