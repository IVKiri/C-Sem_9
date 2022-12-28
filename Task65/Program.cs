// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


void Numbers(int num1, int num2)
{
    if (num2 > num1)
    {
        if (num2 == num1 - 1)
        {
            return;
        }
        Numbers(num1, num2 - 1);
        Console.Write($"{num2} ");
    }
    else if (num2 < num1)
    {
        if (num2 == num1 - 1)
        {
            return;
        }
        Numbers(num2, num1 - 1);
        Console.Write($"{num1} ");
    }
    else
    {
        Console.Write($"{num2} ");
    }
}
Console.Write("Введите число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Numbers(num1, num2);


// void Rec(int n, int m)
// {
//     if (m > n)
//     {
//          if (n == m)
//      {
//          return;
//      }
// Rec(n, m - 1);
// Console.Write($"{m} ");
//     }
//     else if (m < n)
// {
//     if (m == n) return;
// Rec(m, n - 1);
// Console.Write($"{n} ");
// }
// else Console.Write($"{m} ");
// }
// Console.Write("Введите первое значение: ");
// int N = int.Parse(Console.ReadLine());
// Console.Write("Введите второй значение: ");
// int M = int.Parse(Console.ReadLine());
// Rec(N, M);