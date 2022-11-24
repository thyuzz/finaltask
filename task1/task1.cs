/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "4, 2"
N = 8 -> "8, 6, 4, 2,"
*/

Console.Write("Введите значение для N: ");
int n = int.Parse(Console.ReadLine());

int Fun_Recursion(int i){
    if (i == 2) {return 2;}
    else if ((i > 0) && ((i % 2) == 0)){
        Console.Write(" ");
        Console.Write(i);
    }
    return Fun_Recursion(i-1);
}

Console.WriteLine(" " + Fun_Recursion(n));