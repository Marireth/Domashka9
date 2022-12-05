/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Write("Введите натуральное число больше 1: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void NumberCounter(int UserNumber)
{
    if (UserNumber < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{UserNumber} не натуральное число");
        Console.ResetColor();
        return;
    }
    else if (UserNumber == 0) return;

    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("{0,4}", UserNumber);
        NumberCounter(UserNumber - 1);
        Console.ResetColor();
    }   
}

NumberCounter(numberN);