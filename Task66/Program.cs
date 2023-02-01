/* 66. Задайте значения M и N. Напишите программу, которая
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30           */
int getFromUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int CountNaturalSum(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    return n + CountNaturalSum(m, n - 1);
}
int m = getFromUserData("Введите M ");
int n = getFromUserData("Введите N ");
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");