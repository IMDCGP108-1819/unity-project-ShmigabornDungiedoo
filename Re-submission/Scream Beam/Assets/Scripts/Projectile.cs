using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    private Vector2 target;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {//set the cursor to a variable
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        //makes the scream follow the cursor and destroys it when it reaches the cursor
        transform.position = Vector2.MoveTowards(transform.position, target, Speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, target) < 0.2f)
        {
            Destroy(gameObject);
        }
        

    }
}
