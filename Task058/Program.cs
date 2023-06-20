/*  Задача 58: Задайте две матрицы. Напишите программу, которая 
будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18  */

Console.Clear();

int count = Prompt ("Введите количество строк массива: ");
// int columns = Prompt ("Введите количество столбцов массива: ");
Console.WriteLine("Первая матрица");
int [,] arrayA = GetArray(count, count);
PrintArray(arrayA);
Console.WriteLine("Вторая матрица");
int[,] arrayB = GetArray(count, count);
PrintArray(arrayB);
Console.WriteLine("Произведение матриц");
int [,] arrayC = MatrixMultiplication (arrayA, arrayB);
PrintArray(arrayC);


int Prompt (string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int [,] GetArray (int m, int n)
{
    int [,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(0,10);
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

int [,] MatrixMultiplication (int [,] arrA, int [,] arrB)
{
    int [,] arrC = new int [arrA.GetLength(0), arrB.GetLength(1)];
    for(int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            for (int n = 0; n < arrA.GetLength(1); n++)
            {
                arrC [i,j] += arrA[i,n]*arrB[n,j];
            }
        }
    }
    return arrC;
}