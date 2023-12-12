// Задача 4: 
// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string ReverseWords(string x)
{
    // Разделение строки на слова 
    string[] words = x.Split(' '); 
    // Обращение порядка слов 
    Array.Reverse(words); 
    // Соединение слов обратно в строку спробелами 
    return string.Join(" ", words);
}

string input = "I live in Moscow"; 
string result = ReverseWords(input); 
Console.Clear();
Console.WriteLine(result);