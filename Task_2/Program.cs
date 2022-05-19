// Задача:
// Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// Пример:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// При решении задачи условимся, что, как и в примере, 
// пользователь вводит целые положительные числа.
// Наличие третей цифры будет определяться количеством
// введенных символов, если оно не больше 2, то третей
// цифры нет.
String userNumber = Console.ReadLine();
if (userNumber.Length < 3)
    Console.WriteLine("третьей цифры нет");
else
    Console.WriteLine(userNumber[2]);

// Это же решение, но с применением метода.
void showThirdNum(String userNum)
{
    if (userNum.Length < 3)
        Console.WriteLine("третьей цифры нет");
    else
        Console.WriteLine(userNum[2]);
}
showThirdNum(userNumber);