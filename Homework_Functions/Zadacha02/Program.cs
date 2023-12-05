// Задача 2: 
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000); //[100, 999]
}

int FindCountOfEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int element in array) 
    {
         if(element % 2 == 0)
       count++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array); 
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Кол-во четных чисел в массиве: {FindCountOfEvenNumbers(array)}");
