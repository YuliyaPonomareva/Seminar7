/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.  */

Console.Clear();
int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");
int [,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
AverageDate (array);

int Prompt (string messange)
{
    Console.Write(messange);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int [,] GetArray (int m, int n, int minValue, int maxValue)
{
    int [,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue,maxValue);
        }
    }
    return result;
}
 
 void PrintArray (int [,] arr)
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

 void AverageDate (int [,] inArr)
 {
    double end = 0;
    for (int j = 0; j < inArr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < inArr.GetLength(0); i++)
        {
            sum += inArr[i,j];
        }
        end = Math.Round(sum / rows, 2);
        Console.Write($"{end} ");
    }
    Console.Write("- Среднее арифметическое элементов каждого столбца.");
}