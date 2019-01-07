using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    [HideInInspector] public bool facingRight = true; 
    public float moveForce = 365f;
    public float maxSpeed = 5f;
    public float jumpHeight;
    public Text fishCountText;

    private bool canJump = false;
    private int fishCount; 
    
    private Rigidbody2D rb2d;


    
    void Start()
    {
        fishCount = 0;
        rb2d = GetComponent<Rigidbody2D>();
        SetCountText(); 
    }

  

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        //moves right
        if (h * rb2d.velocity.x < maxSpeed)
            rb2d.AddForce(Vector2.right * h * moveForce*Time.deltaTime);
        // moves left
        if (Mathf.Abs(rb2d.velocity.x) > maxSpeed)
            rb2d.velocity = new Vector2(Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y*Time.deltaTime);
        //makes the player flip if moving in a different direstion
        if (h > 0 && !facingRight)
            Flip();
        else if (h < 0 && facingRight)
            Flip();
        //allows to jump
        if (Input.GetButtonDown("Jump") && canJump == true)
        {
            rb2d.AddForce(new Vector2(0.0f, jumpHeight), ForceMode2D.Impulse);
            canJump = false;
        }
               


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //checks if jumping is allowed
        if (collision.collider.CompareTag("Ground"))
        {
            canJump = true;
        }
    }


    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "Fish" and executes the collectibles code
        if (other.gameObject.CompareTag("Fish"))
        {
            other.gameObject.SetActive(false);
            fishCount = fishCount + 1;
            SetCountText();
        }
    }
    //counts fish
    void SetCountText()
    {
        fishCountText.text = "Fish collected: " + fishCount.ToString();

    }

}