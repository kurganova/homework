// Задача 2
//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 21);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }  
}

void ChangeMatrix(int[,] matrix)
{
    int temp;
    int n = matrix.GetLength(0);
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        temp = matrix[0, j];
        matrix[0, j] = matrix[n - 1, j];
        matrix[n - 1, j] = temp;
    }
}

Console.Clear();
int[,] mat = new int[5, 5];
InputMatrix(mat);
Console.WriteLine("Начальный массив: ");
PrintMatrix(mat);
ChangeMatrix(mat);
Console.WriteLine("Первая и последняя строки массива поменялись местами: ");
PrintMatrix(mat);
