using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{

    private static string[] wordList = {"begin", "end"};

    public static string GetRandomWord()
    {
        int rndIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[rndIndex];

        return randomWord;

    }
}
