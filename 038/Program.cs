// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] arr = new double[10];
int arrSize = arr.Length;

for (int i = 0; i < arrSize; i++)
{
    arr[i] = new Random().NextDouble();
    arr[i] = arr[i] * 100;
}
double maxNumber = arr[0];
double minNumber = arr[0];

for(int j = 0; j < arrSize; j++)
{
    if(maxNumber < arr[j]) maxNumber = arr[j];
    if(minNumber > arr[j]) minNumber = arr[j];
}
double difference = maxNumber - minNumber;
Console.Write($"Массив [{String.Join(", ", arr)}] \n");
Console.Write($"Разница между {maxNumber} и {minNumber} = {difference}");


