using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    public float Speed;
    public int score;
    public int highscore;
   

    private Transform playerPos;
    private Player player;



    void Start()
    {
        
        
       //set a player and a player position to a variable
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerPos = GameObject.FindGameObjectWithTag("Player").transform; 
    }



    void Update()
    {
        //makes the enemy move towards the player
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, Speed*Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {//if collides with a player, takes 1 off the health and destroys the enemy
            player.health--;
            Destroy(gameObject);
            Debug.Log(player.health);
        }

        if (other.CompareTag("Projectile"))
        {
            //if projectiles collide with the enemy, the enemy is destroyed, as well as the projectile
            Destroy(other.gameObject);
            Destroy(gameObject);
            
        }
    }
}
