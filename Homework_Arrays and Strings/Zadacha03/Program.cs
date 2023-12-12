// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

bool IsPalindrome(string x)
{   // Нормализация строки путем удаления не буквенно-цифровых символов и приведения к нижнему регистру 
    string normalized = new string(x.Where(char.IsLetterOrDigit).ToArray()).ToLower(); 
    // Сравнение строки с ее перевернутым вариантом 
    return normalized.SequenceEqual(normalized.Reverse()); 
}

string input = "sTYTs";
bool isPalindrome = IsPalindrome(input); 
Console.Clear(); 
Console.WriteLine(isPalindrome? "Да" : "Нет");