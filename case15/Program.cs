/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

bool Weekend(int num)
{
    return num == 6 || num == 7;
}

int number = InputNum("Введите цифру, обозначающую день недели: ");
bool result = Weekend(number);
string strResult = result ? "Этот день является выходным" : "Этот день не является выходным";
Console.WriteLine(strResult);