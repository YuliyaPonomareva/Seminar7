/* Задача 68: Напишите программу вычисления функции 
Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Clear();

int m = Prompt ("Введите положительное число  m: ");
int n = Prompt ("Введите положительное число n: ");
PrintResult(m,n);

int Prompt (string messange)
{
    Console.Write(messange);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void PrintResult (int firstDigit, int secondDigit)
{
  if (firstDigit < 0 || secondDigit < 0)
  {
    Console.WriteLine("Числа должны быть положительными.");
  }
  else
  {
    Console.Write($"Функция Аккермана для чисел {firstDigit} и {secondDigit} = {AсkermanFunction(firstDigit,secondDigit)}");
  }
}

int AсkermanFunction (int firstDigit, int secondDigit)
{
  if (firstDigit == 0) 
  {
    return secondDigit + 1;
  }

  else if (secondDigit == 0)
  {
    return AсkermanFunction(firstDigit - 1, 1);
  } 

  else 
  {
    return AсkermanFunction(firstDigit - 1, AсkermanFunction(firstDigit, secondDigit - 1));
  }
}



// int Ack(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return Ack(m - 1, 1);
//   else return Ack(m - 1, Ack(m, n - 1));
// }

// int InputNumbers(string input) 
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }