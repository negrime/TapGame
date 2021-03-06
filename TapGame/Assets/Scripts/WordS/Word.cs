using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word {

	public string word;
	private int typeIndex;

	WordDisplay display;
  public WordManager wm;
    
    
	public Word (string _word, WordDisplay _display)
	{
		word = _word;
		typeIndex = 0;
		display = _display;
		display.SetWord(word);
	}

	public char GetNextLetter ()
	{
       
		return word[typeIndex];
	}

	public void TypeLetter ()
	{
		typeIndex++;
        display.text.color = Color.green;
        display.RemoveLetter();
       
	}

    public void Error()
    {

        display.text.color = Color.red;
        

    }

    public bool WordTyped(int add)
	{
		bool wordTyped = (typeIndex >= word.Length);
		if (wordTyped)
		{
			display.RemoveWord(add);
            
        }
        

		return wordTyped;
	}

}
