// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// const int leftRange = -100;
// const int rightRange = 100;
// int size = SizeArray("Введите длину массива ");
// int[] array = new int[size];
// Random rand = new Random();

// int SizeArray(string str)
// {
//     Console.Write(str);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
// {

// int count = 0;
// for (int i = 0; i < size; i++)
// {
//     array[size] = rand.Next(leftRange, rightRange + 1);

//     if (array[size] > 99 & array[size] <= 10)
//     {
//         count += 1;
//     }
// }

// }
// array = FillArrayWithRandomNumbers(size, leftRange, rightRange);
// System.Console.WriteLine('[' + string.Join("; ", array) + ']');
// int count1 = FillArrayWithRandomNumbers(array);




// int CountTimes(inr arr)
// {

// return count;
// }
// int count = 0;
//         if (array[size] > 99 & array[size] <= 10)
//         {
//             count += 1;
//         }
//         else System.Console.WriteLine("ошибка");
// int count = CountTimes(size);
// System.Console.WriteLine(count);



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

array = FillArrayWithRandomNumbers(size, leftRange, rightRange);
System.Console.WriteLine('[' + string.Join("; ", array) + ']');


int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 100 & array[i] > 9)
    {
        count += 1;
    }
}

System.Console.WriteLine("Количество чисел в диапазоне = " +count);