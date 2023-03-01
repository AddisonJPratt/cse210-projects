using System;
using System.Collections.Generic;
public class Verse
{
    private List<int> _hiddenIndexes = new List<int>();
    private string _verse;
    private List<Word> _words = new List<Word>();

    public Verse(string verse)
    {
        _verse = verse;
        sepWords();
    }
    private void sepWords()
    {
        string[] splitAtWord =
        _verse.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in splitAtWord)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }
    public void ShowVerse()
    {
        foreach (Word word in _words)
        {
            word.ShowWord();
            Console.Write(" ");
        }
    }
    private int GetRandomIndex(int maximum)
    {
        Random random = new Random();
        int randomIndex = random.Next(0, maximum);
        while (_hiddenIndexes.Contains(randomIndex))
        {
            randomIndex = random.Next(0, maximum);
        }
        _hiddenIndexes.Add(randomIndex);
        return randomIndex;
    }
    public void HideWords()
    {
        int numToHide = _words.Count / 2;
        for (int i = 0; i < 3; i++)
        {
            int randomIndex = GetRandomIndex(_words.Count);
            _words[randomIndex].UnderscoreWord();
        }
    }


}