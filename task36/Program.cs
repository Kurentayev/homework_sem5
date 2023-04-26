// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = GetRandomArray(4);
PrintArray(array);
int sum = FindUnEvenSumInAnArray(array);
Console.WriteLine($"Сумма элементов стоящих на нечётных позициях составляет {sum}");

int[] GetRandomArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

void PrintArray(int[] array)
{

    Console.WriteLine(string.Join(" ", array));
}

int FindUnEvenSumInAnArray(int[] array)
{
    int count = array.Length;
    int index = 0;
    int sum = 0;
    while (index < count)
    {
    
        if(index % 2 != 0)
        {
          sum = sum + array[index];
        }
        index++;
    }
     return sum;
}
