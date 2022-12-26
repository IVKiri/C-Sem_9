// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


 void Numbers(int num1, int num2)
{
    if (num2 == num1-1)
    {
        return;
    }
    Numbers(num1, num2 - 1);
    Console.Write($"{num2} ");
}
Console.Write("Введите число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Numbers(num1, num2);
