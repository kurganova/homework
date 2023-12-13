// Задача 3: 
// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void ReverseArray(int[] array, int first, int last)
{
    if (first < last)
    {
        int temp = array[first];
        array[first] = array[last];
        array[last] = temp;
        ReverseArray(array, first + 1, last - 1);
    }
}

Console.Clear();
int[] arr = {2, 5, 7, 1, 6, 31, 40, 99};
ReverseArray(arr, 0, arr.Length - 1);
string elements = String.Join(" ", arr);
Console.WriteLine(elements);