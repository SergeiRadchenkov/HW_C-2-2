/* Задача 10: Напишите программу, 
которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SecondNum(int num)
{
    int thirdDigit = num / 10 % 10;
    return thirdDigit;
}

int number = InputNum("Введите трёхзначное число: ");
int res = SecondNum(number);
Console.WriteLine($"Вторая цифра трёхзначного числа {res}");