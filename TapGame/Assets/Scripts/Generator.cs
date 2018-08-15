using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
	public GameObject block; // префаб
	public float time;
	public float maxTime;
	
	void Update ()
	{
		if (time >= maxTime)
		{
			time = 0;
			Instantiate(block, transform.position, Quaternion.identity);
			
		}
		else
		{
			time += Time.deltaTime;
		}
	}

	IEnumerator Wait()
	{

		yield return new WaitForSeconds(2);
		Instantiate(block, transform.position, Quaternion.identity);

	}
}
