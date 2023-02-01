/* 69. Напишите программу, которая на вход принимает два числа
А и В, и возводит число А в степень В с помощью рекурсии.   */
int getFromUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int getRaiseDegree(int numA, int numB)
{
    if (numB == 1)
    {
        return numA;
    }
    return numA * getRaiseDegree(numA, numB - 1);
}
int numA = getFromUserData("Введите число A");
int numB = getFromUserData("Введите число B");
int result = getRaiseDegree(numA, numB);
Console.WriteLine(result);
