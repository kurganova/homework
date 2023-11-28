// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

Console.Clear();
Console.Write("Введите число от 10 до 99: ");
int number = Convert.ToInt32(Console.ReadLine());
int n1; 
int n2;
n1 = number / 10;
n2 = number % 10;
if (n1 > n2)
    Console.Write($"{n1}");
else
    Console.Write($"{n2}");
