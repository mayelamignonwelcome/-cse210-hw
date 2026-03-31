using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        const string scriptureFile = "scriptures.txt";

        if (!File.Exists(scriptureFile))
        {
            Console.WriteLine($"Fichier introuvable : {scriptureFile}. Assurez-vous qu'il est présent dans le dossier de l'exécutable.");
            return;
        }

        List<Scripture> scriptures = LoadScripturesFromFile(scriptureFile);
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words, type 'check' to test your memory, or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            if (input.ToLower() == "check")
            {
                Console.WriteLine("\nType the scripture from memory:");
                string userAttempt = Console.ReadLine();
                Console.WriteLine(userAttempt == scripture.GetDisplayText()
                    ? "Correct!"
                    : " Not quite, keep practicing!");
                continue;
            }

            scripture.HideRandomWords();

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ends.");
                break;
            }
        }
    }

    static List<Scripture> LoadScripturesFromFile(string filePath)
    {
        List<Scripture> scriptures = new List<Scripture>();
        foreach (string line in File.ReadAllLines(filePath))
        {
            string[] parts = line.Split('|');
            string referencePart = parts[0];
            string text = parts[1];
            string[] refSplit = referencePart.Split(' ');
            string book = refSplit[0];
            string[] chapterVerse = refSplit[1].Split(':');
            int chapter = int.Parse(chapterVerse[0]);

            if (chapterVerse[1].Contains("-"))
            {
                string[] verses = chapterVerse[1].Split('-');
                scriptures.Add(new Scripture(new Reference(book, chapter, int.Parse(verses[0]), int.Parse(verses[1])), text));
            }
            else
            {
                scriptures.Add(new Scripture(new Reference(book, chapter, int.Parse(chapterVerse[1])), text));
            }
        }
        return scriptures;
    }
}

