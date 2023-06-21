/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Clear();

int n = Prompt ("Введите число: ");
AllNumbersFromN(n);

int Prompt (string messange)
{
    Console.Write(messange);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void AllNumbersFromN (int num)
{
    if ( num >= 1)
    {
        Console.Write($"{num} ");
        AllNumbersFromN(num-1);
    }
}