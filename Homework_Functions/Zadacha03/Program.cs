// Задача 3: 
// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, 
// второй – предпоследним и т.д.)

void inputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10, 11); //[-10, 10]
}

void reversArray(int[] array)
{
    int n = array.Length;
    for(int i = 0; i < n / 2; i++)
    {
        int temp = array[i];
        array[i] = array[n - 1 - i];
        array[n - 1 - i] = temp;
    }
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
inputArray(array); 
Console.WriteLine($"Изначальный массив: [{string.Join(", ", array)}]");
reversArray(array);
Console.WriteLine($"Новый массив: [{string.Join(", ", array)}]");