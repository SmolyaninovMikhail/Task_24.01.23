﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.Clear();
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int X = A;
for (int i = 1; i < B; i++)
{
    X = X * A;
}
Console.WriteLine("A в степени B равно: " + X);