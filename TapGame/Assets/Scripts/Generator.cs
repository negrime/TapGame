using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
	public GameObject block; // префаб
    public GameObject[] buildings = new GameObject[1];
	public float time;
	public float maxTime;
	
	void Update ()
	{
		if (time >= maxTime)
		{
            StartCoroutine("BuildSpawn");
			time = 0;
			Instantiate(block, transform.position, Quaternion.identity);
			
		}
		else
		{
			time += Time.deltaTime;
		}
	}

	IEnumerator BuildSpawn()
	{

		yield return new WaitForSeconds(Random.Range(4, 15));
        int rnd = Random.Range(0, 2);
        GameObject build = Instantiate(buildings[Random.Range(0, buildings.Length)], transform.position, Quaternion.identity);
        build.GetComponent<SpriteRenderer>().flipX = (rnd == 1) ? true : false;
	}
}
