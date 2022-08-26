// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[10];
int arraySize = array.Length;
int count = 0;

for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0) count++;
}
Console.WriteLine($"В массиве [{String.Join(", ", array)}] {count} чётных чисел");


