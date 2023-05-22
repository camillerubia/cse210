using System;

// Responsibilities:
//  - keeps track of the scripture reference and text
//  - can hide words
//  - get the rendered text display


public class Scripture
{
    private string _fullVerse;
    private bool _checker;

    public Scripture(string reference, string text)
    {
        reference = "";
        text = "";
    }

    public void DisplayScripture(List<string> list)
    {

    }

    private void KeyReader()
    {

    }

    private bool ConfirmHide(List<string> newList)
    {
    foreach (string item in newList)
        {
            if (item.Contains("hide"))
            {
                return _checker = true; // Hide
            }
        }

        return _checker = false; // Don't hide
    }

}