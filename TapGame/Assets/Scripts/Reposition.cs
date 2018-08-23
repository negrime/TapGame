using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{

    public Transform reposition;
    public float maxX;
    public float posFix;
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
            transform.position = new Vector2(reposition.position.x + (posFix), reposition.position.y);
        }

    }
}
