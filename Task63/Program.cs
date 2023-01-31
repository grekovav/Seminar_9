/* 63. Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.   */
int getFromUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int userNumber = getFromUserData("Введите значение границы ряда");
printRange(userNumber);
void printRange(int N)
{
    if (N == 0)
    {
        return;
    }
    printRange(N - 1);
    Console.Write(N + ",");
   
}
