/* Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого числа в массиве нет [1,7]-это позиция элемента 1 - строка, 7 - столбец*/

Console.Clear();
int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");
int [,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);
int rowEl = Prompt("Введите номер строки нужного элемента: ");
int columnEl = Prompt("Введите номер столбца нужного элемента: ");
ValueEl(array);


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

 void ValueEl(int [,] arr)
 {
    if (rowEl >= arr.GetLength(0)+1 || columnEl >= arr.GetLength(1)+1)
    {
        Console.WriteLine("Такого элемента нет.");
    }
    else
    {
        int el = arr [rowEl-1,columnEl-1];
        Console.WriteLine($"Этот элемент = {el}");
        
    }
 }
