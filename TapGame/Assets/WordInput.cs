using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{
    public WordManager wordManeger;
    void Update()
    {
        foreach (char letter in Input.inputString)
        {
            wordManeger.TypeLetter(letter);
        }

    }
}
