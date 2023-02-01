/* 64. Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.    */
int getFromUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int userNumber = getFromUserData("Введите положительное число N");
printRange(userNumber);
void printRange(int N)
{
    if (N == 0)
    {
        return;
    }
    Console.Write(N + " ");
    printRange(N - 1);
}
