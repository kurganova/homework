// Задача 3
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int SumRow(int[,] matrix, int i)
{
    int sumRow = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumRow += matrix[i, j];
    }
    return sumRow;
}

Console.Clear();
int[,] mat = new int[4, 7];
InputMatrix(mat);
Console.WriteLine("Массив: ");
PrintMatrix(mat);

int minSumRow = 0;
int sumRow = SumRow(mat, 0);
for (int i = 1; i < mat.GetLength(0); i++)
{
    int temp = SumRow (mat, i);
    if (sumRow > temp)
    {
        sumRow = temp;
        minSumRow = i;
    }
}
minSumRow = minSumRow + 1;

Console.WriteLine();
Console.WriteLine("Строка c наименьшей суммой элементов: " + minSumRow);
Console.WriteLine("Сумма элементов: " + sumRow);

