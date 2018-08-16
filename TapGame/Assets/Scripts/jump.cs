using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{

	private Rigidbody2D rb;
	private Animator anim;
	
	void Start ()
	{

		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown(KeyCode.Space))
		{
			anim.SetTrigger("Jump");
			rb.AddForce(300 * Vector2.up);
		}
		
	}


	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Finish"))
		{
			anim.SetTrigger("Jump");
			rb.AddForce(300 * Vector2.up);
			
		}
	}
}
