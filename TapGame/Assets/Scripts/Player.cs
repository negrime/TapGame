using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Characteristics")]
    public bool isRun;
    public float globalSpeed;
    public int health;
    private Rigidbody2D rb;
    private Animator anim;

    public Generator generator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HealthChecker(health);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Block"))
        {
            //anim.SetInteger("Jump", 4);
            anim.SetInteger("Jump", Random.Range(1, 5));
            anim.SetTrigger("JUMP");

            //rb.AddForce(100 * Vector2.right);
            rb.AddForce(350 * Vector2.up);


        }
    }


    private void HealthChecker(int hp)
    {
        if (hp <= 0)
        {
            Debug.Log("Health <= 0");
            GameOver();
        }
    }

    private void GameOver()
    {
        generator.isGenerate = false;
        isRun = false;
        globalSpeed = 0;
        
    }
}
