// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"N = {n} -> {OrderingNumb(n)}");
string OrderingNumb(int number)
{
    if (number == 0) return string.Empty;
    if (number == 1) return ($"{number}" + OrderingNumb(number - 1));
    return ($"{number}" + ", " + OrderingNumb(number - 1));
}