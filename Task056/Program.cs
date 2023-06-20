/*  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер 
строки с наименьшей суммой элементов: 1 строка  */

Console.Clear();
int rows = Prompt ("Введите количество строк массива: ");
int columns = Prompt ("Введите количество столбцов массива: ");
int [,] array = GetArray(rows,columns, 1, 10);
PrintArray(array);
RowMinSum(array);

int Prompt (string message)
{
    Console.Write(message);
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
            result[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i =0; i <inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void RowMinSum (int[,] arr)
{
    int row=0;
    int minSum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        minSum += arr[0,j];
    }
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i,j];
        }
        
        if (sum < minSum)
        {
            minSum = sum;
            row = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой - {row+1}"); 
}