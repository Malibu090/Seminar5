// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

const int leftRange = 0;
const int rightRange = 10;
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

int[] result = new int[size / 2 + size % 2];

for (int i = 0; i < size / 2; i++)
{

    result[i] = array[i] * array[size - 1 - i];
    if (size % 2 != 0)
    {
        result[result.Length - 1] = array[size / 2];
    }
}



// if (size % 2 == 1)
// {
//     result[(size / 2) + 1] = array[(size / 2) + 1];
// }
// for (int i = 0; i < (size / 2); i++)
// {
//     result[i] = array[i] * array[size - 1 - i];
//     // if ((size / 2) % 2 == 1)
//     // {
//     //     result[(size / 2) + 1] = array[(size / 2) + 1];
//     // }
//     // else
//     // {
//     //     result[i] = array[i] * array[size - 1 - i];
//     // }
// }

// System.Console.WriteLine(result);

System.Console.WriteLine('[' + string.Join("; ", array) + ']');

System.Console.WriteLine('[' + string.Join("; ", result) + ']');
