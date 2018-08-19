using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{

    public Transform reposition;
    public Move move;
    public float maxX;
    void Start()
    {
        
        //friend = reposition.GetComponent<SpriteRenderer>().width;
        //reposition = reposition.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < maxX)
        {
            transform.position = new Vector2(reposition.position.x + (8.88f * 2), reposition.position.y);
        }

    }
}
