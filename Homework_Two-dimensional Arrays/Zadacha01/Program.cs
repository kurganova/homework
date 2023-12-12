// Задача 1
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

Console.Clear();
Console.Write("Введите строку: ");
int row = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int col = Convert.ToInt32(Console.ReadLine()) - 1;
int[,] matrix = new int[6, 5];
InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);

if (row < 0 | row > matrix.GetLength(0) - 1 | col < 0 | col > matrix.GetLength(1) - 1)
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", matrix[row, col]);
}

