// Задача:
// Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// При решении условимся, что вводятся числа от 1 до 7
// и проверка ввода не требуется.

int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber < 6)
    Console.WriteLine("нет");
else
    Console.WriteLine("да");

// Решение с применением метода.
void isWeekend(int dayNum)
{
    if (dayNumber < 6)
        Console.WriteLine("нет");
    else
        Console.WriteLine("да");
}
isWeekend(dayNumber);