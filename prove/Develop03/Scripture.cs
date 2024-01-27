using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
//Scripture design class
public class Scripture
{
    private  Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        string[] scriptureText = text.Split(' ');

        foreach (string word in scriptureText)
        {
            Word wording = new Word(word);
            _words.Add(wording);
        }
    }
    //changed to use boolean and using do-while loop to run
    public void HideRandomWords()//int numberToHide)
    {
        bool tryOut;

        do
        {

        Random atRandom = new Random();
        int num = atRandom.Next(0, _words.Count());
        tryOut = _words[num].IsHidden();
        _words[num].Hide();
        //tried did like how it ran
        //for (int j = 0; j < numberToHide; j++)
        //{
        //int num = atRandom.Next(0, _words.Count());
            
        //_words[num].Hide();
        } 
        while (tryOut == true);   
    }
    public string GetDisplayText()
    {
        List<string> texts = new List<string>();
        
        foreach (Word letters in _words)
        {
            string txt = letters.GetDisplayText();
            texts.Add(txt);
        }
        string allText = String.Join(' ', texts);
        return allText;
    }
    public bool IsCompletelyHidden()
    {
        bool hiddenFully = true;

            foreach (Word wordLetter in _words)
            {
                hiddenFully = wordLetter.IsHidden();
                if (hiddenFully == false)
                {
                    break;
                }
            }
        return hiddenFully;
    }

    public Reference GetScripture() //added to help run the program smoothly for reference in program
    {
        return _reference;
    }


}