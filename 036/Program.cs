// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int[10];
int sum = 0;
int arrSize = arr.Length;

for(int i  = 0; i < arrSize; i++)
{
    arr[i] = new Random().Next(100);
    if (i % 2 == 1) sum += arr[i]; 
}
Console.WriteLine($"Сумма в массиве[{String.Join(", ",arr)}] равна {sum}");
