/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int thirdNumber(int num)
{
    while(num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}

int number = InputNum("Введите число: ");
if(number < 100)
{
    Console.WriteLine("Третья цифра заданного числа отсутствует");
}
else
{
    int result = thirdNumber(number);
    Console.WriteLine($"Третья цифра заданного числа: {result}");
}