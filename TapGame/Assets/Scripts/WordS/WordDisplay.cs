using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour {

    private WordManager wm;
	private Player player;
	public Text text;
	public float fallSpeed = 1f;

    private void Start()
    {
        wm = FindObjectOfType<WordManager>();
	    player = FindObjectOfType<Player>();
    }

	private void Update()
	{
		if (Vector2.Distance(player.transform.position, transform.position) < 2f)
		{
			RemoveWord();
		}
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

	public void RemoveWord (int add = 0)
	{
		wm.hasActiveWord = false;
		Destroy(gameObject);
		player.scores += add;

	}

  

    private void OnTriggerEnter2D(Collider2D collision)
    {
       /* if (collision.CompareTag("Player"))
        {
            wm.hasActiveWord = false;
            Debug.Log("fewwef");
            RemoveWord();
        }
        */
    }

}
