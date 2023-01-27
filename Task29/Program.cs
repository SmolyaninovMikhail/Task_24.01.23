// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран(ввод пользователя с клавиатуры)

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 100);
Console.WriteLine($"Результат: [{string.Join(", ", array)}]");
