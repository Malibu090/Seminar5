// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();

const int leftRange = -10;
const int rightRange = 10;
int size = SizeArray("Введите длину массива ");
int[] array = new int[size];
Random rand = new Random();


int InputNumber(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

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
int A = InputNumber("Введите число ");
array = FillArrayWithRandomNumbers(size, leftRange, rightRange);
System.Console.WriteLine('[' + string.Join("; ", array) + ']');
bool result = false;

for (int i = 0; i < array.Length; i++)
{

    if (array[i] == A)
    {
        result = true;
        break;
    }
}
if (result) 
{
    System.Console.WriteLine("yes");
}
else 
{
    System.Console.WriteLine("no");
}