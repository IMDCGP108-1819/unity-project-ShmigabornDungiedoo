using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIstart : MonoBehaviour
{   //buttons for quitting, starting the game and restarting the game
    public void Quit()
    {
        Application.Quit();
    }

    public void LoadStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
