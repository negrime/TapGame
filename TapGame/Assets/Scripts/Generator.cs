using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    //public GameObject block; // префаб
    public bool isGenerate;

    public GameObject[] buildings = new GameObject[1];
    public GameObject[] blocks = new GameObject[1];
	public float time;
	public float maxTime;
	
	void Update ()
	{
        if (isGenerate)
        {
            Generate(ref time);
        }
    }

    public void Generate(ref float time)
    {
        if (time >= maxTime)
        {
            StartCoroutine("BuildSpawn");
            time = 0;
           // Instantiate(blocks[Random.Range(0, blocks.Length)], transform.position, Quaternion.identity);

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
        build.transform.localScale = (new Vector2(Random.Range(2f, 4f), Random.Range(3f, 4f)));
        //build.GetComponent<Transform>().transform.localScale = (new Vector3(1,1,1));
        build.GetComponent<SpriteRenderer>().flipX = (rnd == 1) ? true : false;
    }

}
	

