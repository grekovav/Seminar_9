/* 67. Напишите программу, которая будет принимать на вход
число и возвращать сумму его цифр.    */
int getFromUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int getSumOfDigits(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return number % 10 + getSumOfDigits(number / 10);
}
int num = getFromUserData("Введите число");
int result = getSumOfDigits(num);
Console.WriteLine(result);