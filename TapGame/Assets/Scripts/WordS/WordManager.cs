using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{

    public List<Word> words;

    public WordSpawner wordSpawner;
    public Player player;
    
    
    private MenuManager menu;
    public bool hasActiveWord;
    public bool fineshed;
    public Word activeWord;
    
    private  string[] csharpList = {"private", "public", "protected", "void", "while", "if", "else", "const", "new" };
    private  string[] delphiList = {"begin", "end", "for", "to", "integer"};
  
   

    private void Start()
    {
        menu = FindObjectOfType<MenuManager>();
    }

    public void AddWord()
    {
        Word word = new Word(GetRandomWord(), wordSpawner.SpawnWord());
        //Debug.Log(gameObject.name);
        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {

            if (activeWord.GetNextLetter() == letter)
            {
                //Debug.Log("Symvol find "  + letter);
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
                   // Debug.Log("FIND ACIVE WORD");
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

    public string  GetRandomWord()
    {
        string result;
        int rndIndex;
        switch (menu.language)
        {
            case 1 :
                rndIndex = Random.Range(0, csharpList.Length);
                result = csharpList[rndIndex];
                break;
            case 2 :
                rndIndex = Random.Range(0, delphiList.Length);
                result = delphiList[rndIndex];
                break;
            default:
                return "keks";
            break;
                
                    
        }
        return result;
    }

}
