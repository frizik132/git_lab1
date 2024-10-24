using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Завдання 1: Знайти кількість символів до останньої коми
        string sentence1 = "Залишилося декілька днів до дня народження, але ще рано святкувати, тому що...";
        int lastCommaIndex = sentence1.LastIndexOf(',');
        if (lastCommaIndex != -1)
        {
            Console.WriteLine("Кількість символів до останньої коми: " + lastCommaIndex);
        }
        else
        {
            Console.WriteLine("Кома не знайдена.");
        }

        // Завдання 2: Видалити всі входження рядка S2 з рядка S1
        string S1 = "Залишилося декілька днів до дня народження, але декілька днів це небагато.";
        string S2 = "декілька";
        string result = S1.Replace(S2, "");
        Console.WriteLine("Результат після видалення входжень S2: " + result);

        // Завдання 3: Вивести слова, що закінчуються на букву "а"
        string sentence2 = "Залишилося декілька днів до дня народження";
        var wordsEndingWithA = sentence2.Split(' ').Where(word => word.EndsWith("а"));
        Console.WriteLine("Слова, що закінчуються на 'а': " + string.Join(", ", wordsEndingWithA));

        // Завдання 4: Сформувати нове речення, виключивши слово з номером t
        string sentence3 = "Залишилося декілька днів до дня народження";
        int t = 3; // Номер слова для виключення
        string[] words = sentence3.Split(' ');
        string newSentence = "";
        for (int i = 0; i < words.Length; i++)
        {
            if (i != t - 1)
            {
                newSentence += words[i] + " ";
            }
        }
        Console.WriteLine("Нове речення без слова під номером t: " + newSentence.Trim());
    }
}
