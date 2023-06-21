/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();

int m = Prompt ("Введите первое число: ");
int n = Prompt ("Введите второе число: ");

if (m > n)
    {
        int temp = m;
        m = n;
        n = temp;
    } 

Console.Write($"Сумма чисел от M до N: {SumDigit(m,n)}");


int Prompt (string messange)
{
    Console.Write(messange);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int  SumDigit (int firstDigit, int secondDigit)
{
    if (firstDigit == secondDigit)
    {
        return secondDigit;
    }
    else
    {
        return  firstDigit + SumDigit(firstDigit+1, secondDigit);
    }
}