using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour {

    private WordManager wm;
	private Player player;
	private Generator generator;
	public Text text;
	public Text addScoreTXT;
	public Transform wordCanvas;
	//public float fallSpeed = 1f;

    private void Start()
    {
        wm = FindObjectOfType<WordManager>();
	    player = FindObjectOfType<Player>();
	    generator = FindObjectOfType<Generator>();
	    wordCanvas = GameObject.Find("Canvas").GetComponent<Transform>();
    }

	private void Update()
	{
		if (Vector2.Distance(player.transform.position, transform.position) < 2f)
		{
			RemoveWord();
			player.HealthDec();
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
		if (add > 0)
		{
			addScoreTXT = Instantiate(addScoreTXT, transform.position, Quaternion.identity, wordCanvas);
			addScoreTXT.text = '+' + player.scoreAddValue.ToString();
			Destroy(addScoreTXT.gameObject, 0.5f);
			
		}
        wm.fineshed = true;
        wm.hasActiveWord = false;
		player.scores += add;
        wm.Remove();
        Destroy(gameObject);



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
