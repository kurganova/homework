// Задача 3: 
// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным 
// и минимальным элементом массива.

void inputArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble(),3);
}

double findMax(double[] array)
{
    double max = array[0];
    foreach (double element in array)
    {
        if(element > max)
        {
            max = element;
        }
    }
    return max;
}

double findMin(double[] array)
{
    double min = array[0];
    foreach (double element in array)
    {
        if(element < min)
        {
            min = element;
        }
    }
    return min;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
inputArray(array); 
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"{findMax(array)} - {findMin(array)} = {Math.Round(findMax(array) - findMin(array), 3)}");
