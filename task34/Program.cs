// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = GetRandomArray(4);
PrintArray(array);
int even = FindEvenElementsInAnArray(array);
Console.WriteLine($"В данном массиве {even} чет чисел");

int[] GetRandomArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{

    Console.WriteLine(string.Join(" ", array));
}

int FindEvenElementsInAnArray(int[] array)
{
   int even = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0)
            even++;
    }
    return even;
}
