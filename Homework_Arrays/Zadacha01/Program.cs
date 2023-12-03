// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов 
// массива, значения которых лежат в отрезке [20,90].

void inputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 101); //[1, 100]
}

int isCheck(int[] array)
{
    int count = 0;
    foreach (int element in array) 
    {
         if(element >= 20 && element <= 90)
       count++;
    }
    return count;
}

Console.Clear();
int n = 10;
int[] array = new int[n];
inputArray(array); 
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Кол-во элементов массива, значения которых лежат в отрезке [20,90]: {isCheck(array)}");
