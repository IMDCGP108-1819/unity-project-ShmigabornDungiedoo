using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenController : MonoBehaviour
{
    public Text highscoreText;
    public Text lastroundtime;



    private float highscore;
    private double Dhighscore;
    private float lasttime;
    private double Dlasttime;



    // Start is called before the first frame update
    void Start()
    {
        lasttime = PlayerPrefs.GetFloat("roundtime");
        Dlasttime = Math.Round(lasttime, 2);
        highscore = PlayerPrefs.GetFloat("Time");
        Dhighscore = Math.Round(highscore, 2);
        highscoreText.text = "Highscore: " + Dhighscore + "s";
        lastroundtime.text = "Last try: " + Dlasttime + "s";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
