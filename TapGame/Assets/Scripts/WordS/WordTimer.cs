using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour {

	public WordManager wordManager;
    private Generator generator;

	public float wordDelay = 1.5f;
	private float nextWordTime = 0f;

    private void Start()
    {
        generator = FindObjectOfType<Generator>();
    }

    private void Update()
	{
		if (Time.time >= nextWordTime && generator.isGenerate)
		{
			wordManager.AddWord();
			nextWordTime = Time.time + wordDelay;
			
		}
	}

}
