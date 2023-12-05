// Задача 3: 
// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным 
// и минимальным элементом массива.

void InputArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble(),3);
}

double FindMax(double[] array)
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

double FindMin(double[] array)
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
InputArray(array); 
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"{FindMax(array)} - {FindMin(array)} = {Math.Round(FindMax(array) - FindMin(array), 3)}");
