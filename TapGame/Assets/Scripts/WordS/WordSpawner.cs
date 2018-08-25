using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour {

	public GameObject wordPrefab;
	public Transform wordCanvas;
    public Transform spawnPos;


    private void Start()
    {
        wordCanvas = GameObject.Find("Canvas").GetComponent<Transform>();
    }
    public WordDisplay SpawnWord ()
	{ 
        Vector3 randomPosition = spawnPos.position;

		GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas);
		WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

		return wordDisplay;
	}

}
