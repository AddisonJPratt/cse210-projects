using System;
using System.Collections.Generic;
public class Word
{
    private string _singleWord;
    private string _hiddenWord = "";
    private bool _isHidden = false;
    public Word(string singleWord)
    {
        _singleWord = singleWord;
        // UnderscoreWord();
    }
    public void UnderscoreWord()
    {
        foreach (char letter in _singleWord)
        {
            if (letter != '.' && letter != '!' && letter != '?' &&
                    letter != ',' && letter != ':' && letter != ';')
            {
                _hiddenWord += "_";
            }
            else
            {
                _hiddenWord += letter;
            }
        }
        _isHidden = true;
    }
    public void ShowWord()
    {
        if (_isHidden)
        {
            Console.Write(_hiddenWord);
        }
        else
        {
            Console.Write(_singleWord);
        }
    }

}