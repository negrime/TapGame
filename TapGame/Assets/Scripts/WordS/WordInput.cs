using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour {

	public WordManager wordManager;
    private Player player;
	private char letterr;

 

    // Update is called once per frame
    void Update () {
        
        
        foreach (char letter in Input.inputString.ToLower())
		{
			switch (letter)
			{
				case 'й':
					letterr = 'q';
					break;
				case 'ц':
					letterr = 'w';
					break;
				case 'у':
					letterr = 'e';
					break;
				case 'к':
					letterr = 'r';
					break;
				case 'е':
					letterr = 't';
					break;
				case 'н':
					letterr = 'y';
					break;
				case 'г':
					letterr = 'u';
					break;
				case 'ш':
					letterr = 'i';
					break;
				case 'щ':
					letterr = 'o';
					break;
				case 'з':
					letterr = 'p';
					break;
				case 'ф':
					letterr = 'a';
					break;
				case 'ы':
					letterr = 's';
					break;
				case 'в':
					letterr = 'd';
					break;
				case 'а':
					letterr = 'f';
					break;
				case 'п':
					letterr = 'g';
					break;
				case 'р':
					letterr = 'h';
					break;
				case 'о':
					letterr = 'j';
					break;
				case 'л':
					letterr = 'k';
					break;
				case 'д':
					letterr = 'l';
					break;
				case 'я':
					letterr = 'z';
					break;
				case 'ч':
					letterr = 'x';
					break;
				case 'с':
					letterr = 'c';
					break;
				case 'м':
					letterr = 'v';
					break;
				case 'и':
					letterr = 'b';
					break;
				case 'т':
					letterr = 'n';
					break;
				case 'ь':
					letterr = 'm';
					break;
				default:
					letterr = letter;
					break;
								
			}
			wordManager.TypeLetter(letterr);
		}
	}

}
