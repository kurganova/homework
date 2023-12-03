// Задача 1: 
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

int SumOfDigits(int n) 
{
    int sum = 0;
    while (n != 0)
    {
        sum += n % 10; // Получаем последнюю цифру числа и добавляем её к сумме.
        n /= 10; // Удаляем последнюю цифру из числа.
    }
    return sum;
}


Console.Clear();
Console.Write("Введите целое число: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine("Чтобы завершить программу, введите символ 'q' или продолжайте ввод, до тех пор пока сумма цифр введенного числа не будет четной");
while(true)
{
    string input = Console.ReadLine()!;
        if (input.ToLower() == "q")
    {
        Console.WriteLine("Программа завершена!");
        break;
    }
    else if(SumOfDigits(n) % 2 == 0)
    {
        Console.WriteLine($"Сумма цифр числа {n} чётная. Программа завершена!");
        break;
    }
    else
    {
        Console.WriteLine($"Продолжайте ввод");
    }
}
 

