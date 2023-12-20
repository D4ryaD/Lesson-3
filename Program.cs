// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
// int sum = 0;
// int[] array = new int[10];
//  Random nums = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = nums.Next(1, 100);
//     Console.Write(array[i] + " ");
// }
// Console.ReadLine();
// for (int i= 0; i < array.Length; i++)
// if (array[i] >=20 && array[i] <=90)
// {
//     sum = sum + 1;
// }
// Console.Write(sum);
// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
// Console.Write("Введите количество элементов массива:");
// int sum = 0;
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];

// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 150);
//     Console.WriteLine(String.Join(" ", array));

// for (int i = 0; i < array.Length; i++)
//     if (array[i] % 2 == 0)
// {
//     sum = sum +1;
// }
// Console.WriteLine(sum);
// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
using System.ComponentModel.DataAnnotations;

Console.Write("Введите количество элементов массива:");
double min = 1;
double max=0;
double k=0;
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().NextDouble();
    Console.WriteLine(String.Join(" ", array));

for (int i = 0; i < array.Length; i++)
if (array[i]>max)
{
    max = array[i];
}
Console.WriteLine(max);

for (int i = 0; i < array.Length; i++)
if (array[i]<min)
{
    min = array[i];
}
Console.WriteLine(min);
k = max - min;
Console.WriteLine($"Разница:"+k);