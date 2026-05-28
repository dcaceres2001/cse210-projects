using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }


    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
           
            List<int> visibleIndices = new List<int>();
            for (int j = 0; j < _words.Count; j++)
            {
                if (!_words[j].IsHidden())
                {
                    visibleIndices.Add(j);
                }
            }

            
            if (visibleIndices.Count == 0)
            {
                break;
            }

            
            int randomIndex = random.Next(visibleIndices.Count);
            _words[visibleIndices[randomIndex]].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden()) return false;
        }
        return true;
    }

    public override string ToString()
    {
        
        string text = string.Join(" ", _words);
        return $"{_reference}:  {text}";
    }
}
