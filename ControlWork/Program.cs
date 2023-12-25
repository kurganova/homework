/* 
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
*/


string[] CreateThreeSymbolArray (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string simbol = array[i];
        if (simbol.Length <= 3)
        {
            count++;
        }
    }
    string[] threeSymbolArray = new string[count];
    for (int n = 0, m = 0; n < array.Length; n++)
    {
        string simbol = array[n];
        if (simbol.Length <= 3)
        {
            threeSymbolArray[m] = simbol;
            m++;
        }
    }
    return threeSymbolArray;
}

Console.Clear();
string[] firstarray = {"Russia", "257", "Denmark", "9", "USA", ":)"};
Console.WriteLine($"Первоначальный массив: [{string.Join(", ", firstarray)}]");
string[] threeSymbolArray = CreateThreeSymbolArray(firstarray);
Console.WriteLine($"Массив из строк, длина которых <= 3 символам : [{string.Join(", ", threeSymbolArray)}]");