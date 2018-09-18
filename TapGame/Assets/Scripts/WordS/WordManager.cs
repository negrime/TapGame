using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{

    public List<Word> words;

    public WordSpawner wordSpawner;
    public Player player;

    public bool hasActiveWord;
    public bool fineshed;
    public Word activeWord;
    //  public WordDisplay display;


    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
       // Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {

            if (activeWord.GetNextLetter() == letter)
            {
                Debug.Log("Symvol find "  + letter);
                activeWord.TypeLetter();
            }
            else
            {
                activeWord.Error();
                player.HealthDec();
            }

        }
        else
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    Debug.Log("FIND ACIVE WORD");
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }  
            }
        }

        if (hasActiveWord && activeWord.WordTyped(player.scoreAddValue))
        {
            hasActiveWord = false;
            fineshed = true;
            Remove();
        }
        
    }


    public void Remove()
    {
        //words.Remove(activeWord);
        words.Clear();
    }


}
