// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

string PrintNumbers(int a, int b)
{
    if (b > 0)
    {
        if (b == 1 || b == a)    
        {
            return $"{b} ";
        }     
        return PrintNumbers(a, b - 1) + $"{b} ";
    }
    return $"В промежутке от {a} до {b} натуральных чисел нет";
}

Console.Clear();
Console.Write("Введите 1-ое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int n = int.Parse(Console.ReadLine()!);

if (m < n)
    Console.WriteLine(PrintNumbers(m, n));
else
    Console.WriteLine(PrintNumbers(n, m));
