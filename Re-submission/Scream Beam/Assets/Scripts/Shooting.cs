using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject shot;
    private Transform playerPos;

    void Start()
    {//get player position
        playerPos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {//creates a shot at player position
            Instantiate(shot, playerPos.position, Quaternion.identity);
        } 
    }
}
