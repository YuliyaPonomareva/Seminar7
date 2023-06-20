/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки 
двумерного массива.Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2  */

Console.Clear();
int rows = Prompt ("Введите количество строк массива: ");
int columns = Prompt ("Введите количество столбцов массива: ");
int [,] array = GetArray(rows,columns, 1, 10);
PrintArray(array);
Console.WriteLine();
DecayRowArray(array);
PrintArray(array);


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

void DecayRowArray(int [,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1)-1; k++)
            {
                if (arr[i,k] < arr[i, k + 1])
                {
                    int temp = arr[i,k];
                    arr[i,k] = arr[i,k + 1];
                    arr[i,k + 1] = temp;
                }
            }
        }
    }
}