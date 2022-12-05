/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Промежуток [M...N]");
Console.ResetColor();
Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void NumberSum(int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        Console.ResetColor();
        return;
    }
    sum = sum + (numberM++);
    NumberSum(numberM, numberN, sum);
}

NumberSum(numberM, numberN, 0);