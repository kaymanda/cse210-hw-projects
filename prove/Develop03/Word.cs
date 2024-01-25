using System;

public class Word
{
    private string _text;
    private bool _isHidden = true;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {

    }

    public void Show()
    {

    }
    public bool IsHidden()
    {
       
        _isHidden = false;
        
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return "";
    }
}