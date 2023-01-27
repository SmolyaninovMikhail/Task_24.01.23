// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (n > 0)
{
    int X = n % 10;
    n = n / 10;
    sum = sum + X;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);