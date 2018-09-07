using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [Header("Characteristics")]
    public int scores;
    public int scoreAddValue;
    public bool isRun;
    
    [HideInInspector]
    public float globalSpeed;
    public float speed;
   
    public int health;
    private Rigidbody2D rb;
    private Animator anim;

    public Generator generator;

    [Header("UI")]
    public Text scoreTxt;

    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        globalSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = scores.ToString();  
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


    public void HealthDec()
    {
        health--;
        HealthChecker(health);
    }
    private void HealthChecker(int hp)
    {
        if (hp <= 0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        scores = 0;
        generator.isGenerate = false;
        isRun = false;
        globalSpeed = 0;
        
    }
}
