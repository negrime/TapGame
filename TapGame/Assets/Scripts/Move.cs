using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

	private Rigidbody2D rb;
	public float speed;
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();


	}
	
	// Update is called once per frame
	void Update ()
	{
		

		transform.Translate(speed * new Vector2(-1,0) * Time.deltaTime, Space.World);
		/*if (Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce(Vector2.up * 300);
		} 
		*/
		
	}

	
	private void FixedUpdate()
	{
		//rb.velocity = speed * new Vector2(1, 0);
	}
}
