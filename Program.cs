/* Задача 47. 
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9    

double[,] array = new double[3, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10) / 1.9;
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
} */
/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет  */
int[,] array = new int[3, 4];

int a;
Console.Write($"Введите число а: ");
int.TryParse(Console.ReadLine(), out a);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == a)
        {
            Console.Write($" {a} -> Такое число в массиве есть ");
            break;
        }

        else
            Console.Write($"{a} -> Такого числа в массиве нет ");
        {
            break;
        }
    }
}