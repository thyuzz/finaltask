/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


Console.Write("Введите значение для конца отразка: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите значение для начала отрезка: ");
int m = int.Parse(Console.ReadLine());
int sum = n;

int Fun_Recursion(int i){
    if (i == m) return m;
    return i + Fun_Recursion(i-1);
}

Console.WriteLine(Fun_Recursion(n));