// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите значение N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"N = {n} -> {OrderingNumb(n)}");
// string OrderingNumb(int number)
// {
//     if (number == 0) return string.Empty;
//     if (number == 1) return ($"{number}" + OrderingNumb(number - 1));
//     return ($"{number}" + ", " + OrderingNumb(number - 1));
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

// Console.Write("Введите значение M: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write($"M = {m}; N = {n} -> {SumValueMN(m, n)}");
// int SumValueMN(int m, int n)
// {
//         if (m == n + 1) return 0;
//         return (m + SumValueMN(m + 1, n));
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите положительное m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите положительное число n: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write($"m = {m}; m = {n} -> A(m,n) = {Akkerman(m, n)}");
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (( m > 0) && (n == 0)) return Akkerman(m - 1, 1);
    else {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}
