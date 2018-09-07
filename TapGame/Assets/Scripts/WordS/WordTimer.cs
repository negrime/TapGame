using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour {

    public WordManager wordManager;
    private Generator generator;
    public GameObject[] blocks = new GameObject[1];

	public float wordDelay;
	public float nextWordTime = 0f;
	

    private void Start()
    {
        generator = FindObjectOfType<Generator>();
    }

    private void Update()
	{
		if (nextWordTime >= wordDelay && generator.isGenerate && wordManager.fineshed)
		{
            Instantiate(blocks[Random.Range(0, blocks.Length)], generator.transform.position, Quaternion.identity);
            wordManager.AddWord();
            wordManager.fineshed = false;
			nextWordTime = 0;
		}
		else if (generator.isGenerate)
		{
			nextWordTime += Time.deltaTime;
		}
	}

}
