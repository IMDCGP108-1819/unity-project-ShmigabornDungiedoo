﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour {

    public void Spinning()
    {//makes the player spin
        gameObject.GetComponent<Animation>().Play("PlayerRotation");
    }
}
