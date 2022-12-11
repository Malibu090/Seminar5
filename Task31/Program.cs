// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например 
const int SIZE = 12;
const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 9;

int[] array = new int[12];
Random rand = new Random();

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void SumPositiveAndNegative(int[] arr, out int sumP, out int sumN)
{
    sumP = 0;
    sumN = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumP += array[i];
        }
        else
        {
            sumN += array[i];
        }
    }
}

array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
System.Console.WriteLine('[' + string.Join("; ", array) + ']');
SumPositiveAndNegative(array, out int sumP, out int sumN);
System.Console.WriteLine($"Сумма положительных элементов = {sumP}, отрицательных = {sumN}");
