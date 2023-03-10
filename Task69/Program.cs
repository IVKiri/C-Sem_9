// Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
int Rec(int a, int b)
{

    if (b == 0)
    {
        return 1;
    }
    return a * Rec(a, b - 1);
}
Console.Write("Введите значение A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите значение B: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine(Rec(a, b));
