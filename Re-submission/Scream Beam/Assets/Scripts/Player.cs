using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public int health;
    public Text healthDisplay;
    public Text LvlTime;


    private float TTime;
    private double DTime;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    private Player player;
    private float PlayerTime;
    private EnemyAI enemyai;

    void Start()
    {
        PlayerTime = PlayerPrefs.GetFloat("Time");
        TTime = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        TTime += Time.deltaTime;
        DTime = Math.Round(TTime, 2);
        LvlTime.text = "Time: " + DTime;
        //print health to ui
        healthDisplay.text = "HEALTH: " + health;
        //player movement 
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        if (TTime > PlayerTime)
        {
            PlayerTime = TTime;
            PlayerPrefs.SetFloat("Time", PlayerTime);
        }
        PlayerPrefs.SetFloat("roundtime", TTime);

        if(health <= 0)
        {//loads the death scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

}

