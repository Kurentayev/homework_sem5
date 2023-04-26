// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int arrLength = GetUserNumber($"Введите длину массива: ", "ОШИБКА! Вы ввели некорректные значения!");
double[] arr = GetRandomArray(arrLength);
PrintArray(arr);
double minNumber = GetMinNumber(arr);
double maxNumber = GetMaxNumber(arr);
double result = maxNumber - minNumber;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива {Math.Round(result, 2)}");

void PrintArray(double[] array)
{
    Console.WriteLine(string.Join(" ", array));
}

double[] GetRandomArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble()*100, 2);
    }
    return array;
}

int GetUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            return userInput;
        }
        else Console.WriteLine(errorMessage);
    }
}

double GetMinNumber(double[] arr)
{
    double min = arr[0];
    foreach (double el in arr)
    {
        if (el < min) min = el;
    }
    return min;
}

double GetMaxNumber(double[] arr)
{
    double max = arr[0];
    foreach (double el in arr)
    {
        if (el > max) max = el;
    }
    return max;
}
