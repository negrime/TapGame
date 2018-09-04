using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

public class Move : MonoBehaviour
{

	private Rigidbody2D rb;
	public float speed;
    public float maxX;

    private Player player;

    public bool destroy;
    public bool physics;
    public enum directionX {left = -1, right = 1};
    public directionX dirX;
    


	 



	void Start ()
	{
        player = FindObjectOfType<Player>(); 
		rb = GetComponent<Rigidbody2D>(); 
	}
	
	// Update is called once per frame
	void Update ()
	{
        //speed = player.globalSpeed;
        if (physics)
        {
            rb.velocity = speed * new Vector2((float)dirX, 0);
        }
        else
        {
           // Debug.Log(gameObject.name + physics);
            transform.Translate(speed * new Vector2((float)dirX, 0) * Time.deltaTime, Space.World);
        }

        if (transform.position.x < maxX && destroy)
		{
			Destroy(gameObject);
		}
	
	}

	
}
