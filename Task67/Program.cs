// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
int sum = 0;
void FindSum(int num)
{
    if (num == 0)
    {
        Console.Write(sum);
        return;
    }
    int temp = num;
    temp%=10;
    sum+=temp;    
    FindSum(num/10);

}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
FindSum(num);

// Оптимальный вариант от препода
// int Rec(int n)
// {

// if (n == 0)
// {
// return 0;
// }
// return n % 10 + Rec(n / 10);

// }
// Console.Write("Введите первое значение: ");
// int N = int.Parse(Console.ReadLine());
// Console.WriteLine(Rec(N));
