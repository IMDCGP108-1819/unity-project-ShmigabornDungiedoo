using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public GameObject restartLevelUI;

    //loads the game over animation
    public void RestartLevelUI()
    {
        restartLevelUI.SetActive(true);
    }

    //load win animation
    public void CompleteLevelUI()
    {
        completeLevelUI.SetActive(true);
    }
    //delays the restart a bit
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }


    }
    //restarts the scene
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //loads next scene
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}


