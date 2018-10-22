using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
    public WordManager wm;

    [Header("UI")]
    public Text scoreTxt;

    public Text healthTxt;
    
    public Text speedTxt;
 
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        wm = FindObjectOfType<WordManager>();
    }

    // Update is called once per frame
    void Update()
    {
        healthTxt.text = "Heath: " + health.ToString();
        scoreTxt.text = scores.ToString();
        globalSpeed = speed;
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
            if (health > 0)
            health--;
            HealthChecker(health);
            healthTxt.text = "Heath: " + health.ToString();          
    }
    
    private void HealthChecker(int hp)
    {
        if (hp <= 0 && isRun)
        {
            Debug.Log("Gameover");
            GameOver();
            health = 0;
            anim.SetTrigger("Die 0");
        }
    }

    private void GameOver()
    {
        scores = 0;
        generator.isGenerate = false;
        isRun = false;
        globalSpeed = 0;
        StartCoroutine("PauseLoad"); //Пауза перед перезапуском уровня
         //Application.LoadLevel("SampleScene");
    }

    public void SetSpeed(float speed)
    {
        this.speed = speed;
        speedTxt.text = "Speed: " + this.speed.ToString("0");
    }
    IEnumerator PauseLoad()
    {
        yield return new WaitForSeconds(3);
        Application.LoadLevel("SampleScene");
    } 
        
    public void Stumble()
    {
        if (health >= 1)
        {
            anim.SetTrigger("STUMBLE");
        }
    }
        
       

}
