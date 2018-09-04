using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour {

	public WordManager wordManager;
    private Generator generator;

	public float wordDelay;
	public float nextWordTime = 0f;
	

    private void Start()
    {
        generator = FindObjectOfType<Generator>();
    }

    private void Update()
	{
		if (nextWordTime >= wordDelay && generator.isGenerate)
		{
			wordManager.AddWord();
			nextWordTime = 0;
		}
		else if (generator.isGenerate)
		{
			nextWordTime += Time.deltaTime;
		}
	}

}
