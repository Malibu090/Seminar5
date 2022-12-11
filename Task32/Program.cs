// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
Console.Clear();
const int leftRange = -100;
const int rightRange = 100;
int size = SizeArray("Введите длину массива ");
int[] array = new int[size];
Random rand = new Random();

int SizeArray(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int[] ChangeArray(int[] array)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = -array[i];
    }
    return array;
}

array = FillArrayWithRandomNumbers(size, leftRange, rightRange);
System.Console.WriteLine('[' + string.Join("; ", array) + ']');

array = ChangeArray(array);
System.Console.WriteLine('[' + string.Join("; ", array) + ']');
