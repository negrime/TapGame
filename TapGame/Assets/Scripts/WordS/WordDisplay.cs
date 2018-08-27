using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour {

    public WordManager wm;
	public Text text;
	public float fallSpeed = 1f;

    private void Start()
    {
        wm = FindObjectOfType<WordManager>();
    }
    public void SetWord (string word)
	{
		text.text = word;
	}

	public void RemoveLetter ()
	{
		text.text = text.text.Remove(0, 1);
		//text.color = Color.green;
	}

	public void RemoveWord ()
	{
		Destroy(gameObject);
	}

  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            wm.hasActiveWord = false;
            Debug.Log("fewwef");
            RemoveWord();
        }
    }

}
