// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

string CreateStringFromMatrix(char[,]matrix)
{ string result = "";
for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {  
            result += matrix[i, j]; 
        } 
    } 
    return result; 
}

Console.Clear();
char[,] charMatrix = new char[,] {{'a', 'b', '4'}, {'c', 'd', '2'}};
string result = CreateStringFromMatrix(charMatrix);
Console.WriteLine(result);
