// Задача 2: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if ((m > 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Clear();
Console.Write("Введите 1-ое неотрицательное число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое неотрицательное число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Функция Аккермана A(m, n) = {Akkerman(m, n)}");
