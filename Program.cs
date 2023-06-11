// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Введите число");
int M = Convert.ToInt32(Console.ReadLine());


string  Rec (int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return(start + Rec(start - 1, end));
}
Console.WriteLine(Rec(M ,1));

// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите 1 число");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int N = Convert.ToInt32(Console.ReadLine());


int  Rec (int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return(start + Rec(start + 1, end));
}
Console.WriteLine(Rec(M ,N));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = aker(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int aker(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return aker(m - 1, 1);
  else return aker(m - 1, aker(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}