// Задача 2: 
// Задайте массив на 10 целых чисел. Напишите программу, которая определяет кол-во чётных чисел в массиве.

void inputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 101); //[-100, 100]
}

int findCountOfEvenNumbers(int[] array)
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
int n = 10;
int[] array = new int[n];
inputArray(array); 
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Кол-во четных чисел в массиве: {findCountOfEvenNumbers(array)}");
