using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

public class Move : MonoBehaviour
{

	private Rigidbody2D rb;
	public float speed;
	public Text txt; // с этим надо что-то делать
	public string[] words = new string[] {"BEGIN", "END", "PROCEDURE", "FUNCTION",
										"DO WHILE"}; // с этим тоже нужно что-то делать
	

	public string word; 



	void Start ()
	{
		word = words[Random.Range(0, words.Length)]; // рандмное слово для объекта
		rb = GetComponent<Rigidbody2D>(); // тут все ясно
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate(speed * new Vector2(-1,0) * Time.deltaTime, Space.World); // перемещение


		if (transform.position.x < -11)
		{
			Destroy(this.gameObject);
		}
		// прыжок
		/*if (Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce(Vector2.up * 300);
		} 
		*/
	}

	
}
